using System.Collections.Generic;

namespace HKX2
{
    public class hkpStorageSampledHeightFieldShape : hkpSampledHeightFieldShape
    {
        public List<float> m_storage;
        public bool m_triangleFlip;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_storage = des.ReadSingleArray(br);
            m_triangleFlip = br.ReadBoolean();
            br.ReadUInt64();
            br.ReadUInt32();
            br.ReadUInt16();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteSingleArray(bw, m_storage);
            bw.WriteBoolean(m_triangleFlip);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}