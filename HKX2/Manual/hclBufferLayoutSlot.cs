namespace HKX2
{
    public class hclBufferLayoutSlot : IHavokObject
    {
        public SlotFlags m_flags;
        public byte m_stride;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_flags = (SlotFlags) br.ReadByte();
            m_stride = br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteByte((byte) m_flags);
            bw.WriteByte(m_stride);
        }
    }
}