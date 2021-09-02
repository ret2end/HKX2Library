namespace HKX2
{
    public class hclSimulationSetupMeshMapOptions : IHavokObject
    {
        public float m_collapseThreshold;

        public bool m_collapseVertices;
        public hclVertexSelectionInput m_vertexSelection;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_collapseVertices = br.ReadBoolean();
            br.ReadUInt16();
            br.ReadByte();
            m_collapseThreshold = br.ReadSingle();
            m_vertexSelection = new hclVertexSelectionInput();
            m_vertexSelection.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteBoolean(m_collapseVertices);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            bw.WriteSingle(m_collapseThreshold);
            m_vertexSelection.Write(s, bw);
        }
    }
}