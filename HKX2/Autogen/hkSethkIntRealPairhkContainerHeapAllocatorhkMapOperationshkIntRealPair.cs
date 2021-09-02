using System.Collections.Generic;

namespace HKX2
{
    public class hkSethkIntRealPairhkContainerHeapAllocatorhkMapOperationshkIntRealPair : IHavokObject
    {
        public List<hkIntRealPair> m_elem;
        public int m_numElems;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_elem = des.ReadClassArray<hkIntRealPair>(br);
            m_numElems = br.ReadInt32();
            br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassArray(bw, m_elem);
            bw.WriteInt32(m_numElems);
            bw.WriteUInt32(0);
        }
    }
}