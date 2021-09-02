namespace HKX2
{
    public class hkcdStaticMeshTreeBasePrimitiveDataRunBaseunsignedint : IHavokObject
    {
        public byte m_count;
        public byte m_index;

        public uint m_value;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_value = br.ReadUInt32();
            m_index = br.ReadByte();
            m_count = br.ReadByte();
            br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_value);
            bw.WriteByte(m_index);
            bw.WriteByte(m_count);
            bw.WriteUInt16(0);
        }
    }
}