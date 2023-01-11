using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbMirroredSkeletonInfo Signatire: 0xc6c2da4f size: 48 flags: FLAGS_NONE

    // m_mirrorAxis m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_bonePairMap m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    public partial class hkbMirroredSkeletonInfo : hkReferencedObject
    {
        public Vector4 m_mirrorAxis { set; get; } = default;
        public IList<short> m_bonePairMap { set; get; } = new List<short>();

        public override uint Signature => 0xc6c2da4f;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_mirrorAxis = br.ReadVector4();
            m_bonePairMap = des.ReadInt16Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteVector4(m_mirrorAxis);
            s.WriteInt16Array(bw, m_bonePairMap);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_mirrorAxis = xd.ReadVector4(xe, nameof(m_mirrorAxis));
            m_bonePairMap = xd.ReadInt16Array(xe, nameof(m_bonePairMap));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4(xe, nameof(m_mirrorAxis), m_mirrorAxis);
            xs.WriteNumberArray(xe, nameof(m_bonePairMap), m_bonePairMap);
        }
    }
}

