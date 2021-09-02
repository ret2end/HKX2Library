using System.Collections.Generic;

namespace HKX2
{
    public class hkOffsetBitFieldStoragehkArrayunsignedinthkContainerHeapAllocator : IHavokObject
    {
        public int m_offset;

        public List<uint> m_words;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_words = des.ReadUInt32Array(br);
            m_offset = br.ReadInt32();
            br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteUInt32Array(bw, m_words);
            bw.WriteInt32(m_offset);
            bw.WriteUInt32(0);
        }
    }
}