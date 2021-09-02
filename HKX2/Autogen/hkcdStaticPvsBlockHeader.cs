namespace HKX2
{
    public class hkcdStaticPvsBlockHeader : IHavokObject
    {
        public uint m_length;

        public uint m_offset;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_offset = br.ReadUInt32();
            m_length = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_offset);
            bw.WriteUInt32(m_length);
        }
    }
}