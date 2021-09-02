using System.Collections.Generic;

namespace HKX2
{
    public class hkaiDirectedGraphInstanceFreeBlockList : IHavokObject
    {
        public List<int> m_blocks;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_blocks = des.ReadInt32Array(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteInt32Array(bw, m_blocks);
        }
    }
}