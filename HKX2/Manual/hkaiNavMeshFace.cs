namespace HKX2
{
    public class hkaiNavMeshFace : IHavokObject
    {
        public short m_clusterIndex;
        public short m_numEdges;
        public short m_numUserEdges;
        public ushort m_padding;

        public int m_startEdgeIndex;
        public int m_startUserEdgeIndex;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_startEdgeIndex = br.ReadInt32();
            m_startUserEdgeIndex = br.ReadInt32();
            m_numEdges = br.ReadInt16();
            m_numUserEdges = br.ReadInt16();
            m_clusterIndex = br.ReadInt16();
            m_padding = br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_startEdgeIndex);
            bw.WriteInt32(m_startUserEdgeIndex);
            bw.WriteInt16(m_numEdges);
            bw.WriteInt16(m_numUserEdges);
            bw.WriteInt16(m_clusterIndex);
            bw.WriteUInt16(m_padding);
        }
    }
}