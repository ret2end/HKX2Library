namespace HKX2
{
    public class hkUuid : IHavokObject
    {
        public uint m_data_0;
        public uint m_data_1;
        public uint m_data_2;
        public uint m_data_3;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_data_0 = br.ReadUInt32();
            m_data_1 = br.ReadUInt32();
            m_data_2 = br.ReadUInt32();
            m_data_3 = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_data_0);
            bw.WriteUInt32(m_data_1);
            bw.WriteUInt32(m_data_2);
            bw.WriteUInt32(m_data_3);
        }
    }
}