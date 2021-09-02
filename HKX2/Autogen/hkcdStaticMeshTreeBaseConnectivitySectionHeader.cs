namespace HKX2
{
    public class hkcdStaticMeshTreeBaseConnectivitySectionHeader : IHavokObject
    {
        public uint m_baseGlobal;

        public uint m_baseLocal;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_baseLocal = br.ReadUInt32();
            m_baseGlobal = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_baseLocal);
            bw.WriteUInt32(m_baseGlobal);
        }
    }
}