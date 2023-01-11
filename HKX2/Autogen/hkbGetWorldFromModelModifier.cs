using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbGetWorldFromModelModifier Signatire: 0x873fc6f7 size: 112 flags: FLAGS_NONE

    // m_translationOut m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_rotationOut m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    public partial class hkbGetWorldFromModelModifier : hkbModifier
    {
        public Vector4 m_translationOut { set; get; } = default;
        public Quaternion m_rotationOut { set; get; } = default;

        public override uint Signature => 0x873fc6f7;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_translationOut = br.ReadVector4();
            m_rotationOut = des.ReadQuaternion(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteVector4(m_translationOut);
            s.WriteQuaternion(bw, m_rotationOut);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_translationOut = xd.ReadVector4(xe, nameof(m_translationOut));
            m_rotationOut = xd.ReadQuaternion(xe, nameof(m_rotationOut));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4(xe, nameof(m_translationOut), m_translationOut);
            xs.WriteQuaternion(xe, nameof(m_rotationOut), m_rotationOut);
        }
    }
}

