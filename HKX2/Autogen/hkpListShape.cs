using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpListShape Signatire: 0xa1937cbd size: 144 flags: FLAGS_NONE

    // m_childInfo m_class: hkpListShapeChildInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_flags m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_numDisabledChildren m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 66 flags: FLAGS_NONE enum: 
    // m_aabbHalfExtents m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_aabbCenter m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_enabledChildren m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 8 offset: 112 flags: FLAGS_NONE enum: 
    public partial class hkpListShape : hkpShapeCollection
    {
        public IList<hkpListShapeChildInfo> m_childInfo { set; get; } = new List<hkpListShapeChildInfo>();
        public ushort m_flags { set; get; } = default;
        public ushort m_numDisabledChildren { set; get; } = default;
        public Vector4 m_aabbHalfExtents { set; get; } = default;
        public Vector4 m_aabbCenter { set; get; } = default;
        public uint[] m_enabledChildren = new uint[8];

        public override uint Signature => 0xa1937cbd;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_childInfo = des.ReadClassArray<hkpListShapeChildInfo>(br);
            m_flags = br.ReadUInt16();
            m_numDisabledChildren = br.ReadUInt16();
            br.Position += 12;
            m_aabbHalfExtents = br.ReadVector4();
            m_aabbCenter = br.ReadVector4();
            m_enabledChildren = des.ReadUInt32CStyleArray(br, 8);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_childInfo);
            bw.WriteUInt16(m_flags);
            bw.WriteUInt16(m_numDisabledChildren);
            bw.Position += 12;
            bw.WriteVector4(m_aabbHalfExtents);
            bw.WriteVector4(m_aabbCenter);
            s.WriteUInt32CStyleArray(bw, m_enabledChildren);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_childInfo = xd.ReadClassArray<hkpListShapeChildInfo>(xe, nameof(m_childInfo));
            m_flags = xd.ReadUInt16(xe, nameof(m_flags));
            m_numDisabledChildren = xd.ReadUInt16(xe, nameof(m_numDisabledChildren));
            m_aabbHalfExtents = xd.ReadVector4(xe, nameof(m_aabbHalfExtents));
            m_aabbCenter = xd.ReadVector4(xe, nameof(m_aabbCenter));
            m_enabledChildren = xd.ReadUInt32CStyleArray(xe, nameof(m_enabledChildren), 8);
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkpListShapeChildInfo>(xe, nameof(m_childInfo), m_childInfo);
            xs.WriteNumber(xe, nameof(m_flags), m_flags);
            xs.WriteNumber(xe, nameof(m_numDisabledChildren), m_numDisabledChildren);
            xs.WriteVector4(xe, nameof(m_aabbHalfExtents), m_aabbHalfExtents);
            xs.WriteVector4(xe, nameof(m_aabbCenter), m_aabbCenter);
            xs.WriteNumberArray(xe, nameof(m_enabledChildren), m_enabledChildren);
        }
    }
}

