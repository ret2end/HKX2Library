namespace HKX2
{
    public class hkcdStaticMeshTreeBaseEdge : IHavokObject
    {
        public uint m_keyAndIndex;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_keyAndIndex = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_keyAndIndex);
        }
    }
}