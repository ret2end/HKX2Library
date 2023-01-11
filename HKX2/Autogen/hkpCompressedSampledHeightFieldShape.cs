using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpCompressedSampledHeightFieldShape Signatire: 0x97b6e143 size: 144 flags: FLAGS_NONE

    // m_storage m_class:  Type.TYPE_ARRAY Type.TYPE_UINT16 arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_triangleFlip m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    // m_offset m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 132 flags: FLAGS_NONE enum: 
    // m_scale m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 136 flags: FLAGS_NONE enum: 
    public partial class hkpCompressedSampledHeightFieldShape : hkpSampledHeightFieldShape
    {
        public IList<ushort> m_storage { set; get; } = new List<ushort>();
        public bool m_triangleFlip { set; get; } = default;
        public float m_offset { set; get; } = default;
        public float m_scale { set; get; } = default;

        public override uint Signature => 0x97b6e143;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_storage = des.ReadUInt16Array(br);
            m_triangleFlip = br.ReadBoolean();
            br.Position += 3;
            m_offset = br.ReadSingle();
            m_scale = br.ReadSingle();
            br.Position += 4;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteUInt16Array(bw, m_storage);
            bw.WriteBoolean(m_triangleFlip);
            bw.Position += 3;
            bw.WriteSingle(m_offset);
            bw.WriteSingle(m_scale);
            bw.Position += 4;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_storage = xd.ReadUInt16Array(xe, nameof(m_storage));
            m_triangleFlip = xd.ReadBoolean(xe, nameof(m_triangleFlip));
            m_offset = xd.ReadSingle(xe, nameof(m_offset));
            m_scale = xd.ReadSingle(xe, nameof(m_scale));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumberArray(xe, nameof(m_storage), m_storage);
            xs.WriteBoolean(xe, nameof(m_triangleFlip), m_triangleFlip);
            xs.WriteFloat(xe, nameof(m_offset), m_offset);
            xs.WriteFloat(xe, nameof(m_scale), m_scale);
        }
    }
}

