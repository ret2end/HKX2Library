namespace HKX2
{
    public class hkaiNavMeshGenerationSettingsWallClimbingSettings : IHavokObject
    {
        public bool m_enableWallClimbing;
        public bool m_excludeWalkableFaces;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_enableWallClimbing = br.ReadBoolean();
            m_excludeWalkableFaces = br.ReadBoolean();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteBoolean(m_enableWallClimbing);
            bw.WriteBoolean(m_excludeWalkableFaces);
        }
    }
}