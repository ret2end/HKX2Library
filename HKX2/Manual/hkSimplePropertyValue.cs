namespace HKX2
{
    public class hkSimplePropertyValue : IHavokObject
    {
        public ulong m_data;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_data = br.ReadUInt64();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt64(m_data);
        }
    }
}