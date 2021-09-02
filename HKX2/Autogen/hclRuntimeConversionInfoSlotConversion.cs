namespace HKX2
{
    public class hclRuntimeConversionInfoSlotConversion : IHavokObject
    {
        public byte m_elements_0;
        public byte m_elements_1;
        public byte m_elements_2;
        public byte m_elements_3;
        public byte m_index;
        public byte m_numElements;
        public bool m_partialWrite;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_elements_0 = br.ReadByte();
            m_elements_1 = br.ReadByte();
            m_elements_2 = br.ReadByte();
            m_elements_3 = br.ReadByte();
            m_numElements = br.ReadByte();
            m_index = br.ReadByte();
            m_partialWrite = br.ReadBoolean();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteByte(m_elements_0);
            bw.WriteByte(m_elements_1);
            bw.WriteByte(m_elements_2);
            bw.WriteByte(m_elements_3);
            bw.WriteByte(m_numElements);
            bw.WriteByte(m_index);
            bw.WriteBoolean(m_partialWrite);
        }
    }
}