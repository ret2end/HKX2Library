namespace HKX2
{
    public class hkpMoppCodeReindexedTerminal : IHavokObject
    {
        public uint m_origShapeKey;
        public uint m_reindexedShapeKey;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_origShapeKey = br.ReadUInt32();
            m_reindexedShapeKey = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_origShapeKey);
            bw.WriteUInt32(m_reindexedShapeKey);
        }
    }
}