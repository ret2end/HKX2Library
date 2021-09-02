namespace HKX2
{
    public class hkBitFieldBasehkOffsetBitFieldStoragehkArrayunsignedinthkContainerHeapAllocator : IHavokObject
    {
        public hkOffsetBitFieldStoragehkArrayunsignedinthkContainerHeapAllocator m_storage;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_storage = new hkOffsetBitFieldStoragehkArrayunsignedinthkContainerHeapAllocator();
            m_storage.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_storage.Write(s, bw);
        }
    }
}