namespace HKX2
{
    public class hkaiHierarchyUtilsClusterSettings : IHavokObject
    {
        public hkaiAgentTraversalInfo m_agentInfo;

        public int m_desiredFacesPerCluster;
        public hkaiNavMeshPathSearchParameters m_searchParameters;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_desiredFacesPerCluster = br.ReadInt32();
            br.ReadUInt64();
            br.ReadUInt32();
            m_searchParameters = new hkaiNavMeshPathSearchParameters();
            m_searchParameters.Read(des, br);
            m_agentInfo = new hkaiAgentTraversalInfo();
            m_agentInfo.Read(des, br);
            br.ReadUInt64();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_desiredFacesPerCluster);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            m_searchParameters.Write(s, bw);
            m_agentInfo.Write(s, bw);
            bw.WriteUInt64(0);
        }
    }
}