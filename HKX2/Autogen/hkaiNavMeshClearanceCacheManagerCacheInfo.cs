namespace HKX2
{
    public class hkaiNavMeshClearanceCacheManagerCacheInfo : IHavokObject
    {
        public float m_clearanceCeiling;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_clearanceCeiling = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_clearanceCeiling);
        }
    }
}