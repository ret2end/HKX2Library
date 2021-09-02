namespace HKX2
{
    public class hkaiSplitGenerationSnapshot : IHavokObject
    {
        public hkaiNavMeshGenerationSnapshot m_generationSnapshot;
        public hkaiSplitGenerationUtilsSettings m_splitSettings;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_generationSnapshot = new hkaiNavMeshGenerationSnapshot();
            m_generationSnapshot.Read(des, br);
            m_splitSettings = new hkaiSplitGenerationUtilsSettings();
            m_splitSettings.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_generationSnapshot.Write(s, bw);
            m_splitSettings.Write(s, bw);
        }
    }
}