namespace HKX2
{
    public class hkaiGraphPathSearchParameters : IHavokObject
    {
        public hkaiSearchParametersBufferSizes m_bufferSizes;

        public float m_heuristicWeight;
        public hkaiSearchParametersBufferSizes m_hierarchyBufferSizes;
        public bool m_useHierarchicalHeuristic;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_heuristicWeight = br.ReadSingle();
            m_useHierarchicalHeuristic = br.ReadBoolean();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt16();
            br.ReadByte();
            m_bufferSizes = new hkaiSearchParametersBufferSizes();
            m_bufferSizes.Read(des, br);
            m_hierarchyBufferSizes = new hkaiSearchParametersBufferSizes();
            m_hierarchyBufferSizes.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_heuristicWeight);
            bw.WriteBoolean(m_useHierarchicalHeuristic);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            m_bufferSizes.Write(s, bw);
            m_hierarchyBufferSizes.Write(s, bw);
        }
    }
}