using System.Collections.Generic;

namespace HKX2
{
    public class hkpCompressedSampledHeightFieldShape : hkpSampledHeightFieldShape
    {
        public float m_offset;
        public float m_scale;

        public List<ushort> m_storage;
        public bool m_triangleFlip;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_storage = des.ReadUInt16Array(br);
            m_triangleFlip = br.ReadBoolean();
            br.ReadUInt16();
            br.ReadByte();
            m_offset = br.ReadSingle();
            m_scale = br.ReadSingle();
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteUInt16Array(bw, m_storage);
            bw.WriteBoolean(m_triangleFlip);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            bw.WriteSingle(m_offset);
            bw.WriteSingle(m_scale);
            bw.WriteUInt32(0);
        }
    }
}