namespace HKX2
{
    public class hkaiNavVolumeInstanceCellInstance : IHavokObject
    {
        public int m_numEdges;

        public int m_startEdgeIndex;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_startEdgeIndex = br.ReadInt32();
            m_numEdges = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_startEdgeIndex);
            bw.WriteInt32(m_numEdges);
        }
    }
}