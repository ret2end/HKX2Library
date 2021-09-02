namespace HKX2
{
    public class hclRuntimeConversionInfoElementConversion : IHavokObject
    {
        public VectorConversion m_conversion;

        public byte m_index;
        public byte m_offset;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_index = br.ReadByte();
            m_offset = br.ReadByte();
            m_conversion = (VectorConversion) br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteByte(m_index);
            bw.WriteByte(m_offset);
            bw.WriteByte((byte) m_conversion);
        }
    }
}