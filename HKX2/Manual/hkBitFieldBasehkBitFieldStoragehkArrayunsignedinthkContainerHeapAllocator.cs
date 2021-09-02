namespace HKX2
{
    public class hkBitFieldBasehkBitFieldStoragehkArrayunsignedinthkContainerHeapAllocator : IHavokObject
    {
        public hkBitFieldStoragehkArrayunsignedinthkContainerHeapAllocator m_storage;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_storage = new hkBitFieldStoragehkArrayunsignedinthkContainerHeapAllocator();
            m_storage.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_storage.Write(s, bw);
        }
    }
}