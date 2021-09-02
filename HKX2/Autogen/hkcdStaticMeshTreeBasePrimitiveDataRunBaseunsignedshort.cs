namespace HKX2
{
    public class hkcdStaticMeshTreeBasePrimitiveDataRunBaseunsignedshort : IHavokObject
    {
        public byte m_count;
        public byte m_index;

        public ushort m_value;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_value = br.ReadUInt16();
            m_index = br.ReadByte();
            m_count = br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt16(m_value);
            bw.WriteByte(m_index);
            bw.WriteByte(m_count);
        }
    }
}