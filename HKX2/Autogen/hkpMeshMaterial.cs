namespace HKX2
{
    public class hkpMeshMaterial : IHavokObject
    {
        public uint m_filterInfo;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_filterInfo = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_filterInfo);
        }
    }
}