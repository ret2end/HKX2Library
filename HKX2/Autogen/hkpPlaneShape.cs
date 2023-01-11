using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpPlaneShape Signatire: 0xc36bbd30 size: 80 flags: FLAGS_NONE

    // m_plane m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_aabbCenter m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_aabbHalfExtents m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    public partial class hkpPlaneShape : hkpHeightFieldShape
    {
        public Vector4 m_plane { set; get; } = default;
        public Vector4 m_aabbCenter { set; get; } = default;
        public Vector4 m_aabbHalfExtents { set; get; } = default;

        public override uint Signature => 0xc36bbd30;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_plane = br.ReadVector4();
            m_aabbCenter = br.ReadVector4();
            m_aabbHalfExtents = br.ReadVector4();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteVector4(m_plane);
            bw.WriteVector4(m_aabbCenter);
            bw.WriteVector4(m_aabbHalfExtents);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_plane = xd.ReadVector4(xe, nameof(m_plane));
            m_aabbCenter = xd.ReadVector4(xe, nameof(m_aabbCenter));
            m_aabbHalfExtents = xd.ReadVector4(xe, nameof(m_aabbHalfExtents));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4(xe, nameof(m_plane), m_plane);
            xs.WriteVector4(xe, nameof(m_aabbCenter), m_aabbCenter);
            xs.WriteVector4(xe, nameof(m_aabbHalfExtents), m_aabbHalfExtents);
        }
    }
}

