namespace HKX2
{
    public class hkcdStaticMeshTreeBaseSectionPrimitives : IHavokObject
    {
        public uint m_data;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_data = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_data);
        }
    }
}