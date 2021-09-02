namespace HKX2
{
    public enum Direction
    {
        SIMULATION_TO_DISPLAY = 0,
        DISPLAY_TO_SIMULATION = 1
    }

    public class hclVertexGatherSetupObject : hclOperatorSetupObject
    {
        public Direction m_direction;
        public hclBufferSetupObject m_displayBuffer;
        public hclVertexSelectionInput m_displayVertexSelection;
        public float m_gatherAllThreshold;
        public bool m_gatherNormals;

        public string m_name;
        public hclSimClothBufferSetupObject m_simulationBuffer;
        public hclVertexSelectionInput m_simulationParticleSelection;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_direction = (Direction) br.ReadUInt32();
            br.ReadUInt32();
            m_simulationBuffer = des.ReadClassPointer<hclSimClothBufferSetupObject>(br);
            m_simulationParticleSelection = new hclVertexSelectionInput();
            m_simulationParticleSelection.Read(des, br);
            m_displayBuffer = des.ReadClassPointer<hclBufferSetupObject>(br);
            m_displayVertexSelection = new hclVertexSelectionInput();
            m_displayVertexSelection.Read(des, br);
            m_gatherAllThreshold = br.ReadSingle();
            m_gatherNormals = br.ReadBoolean();
            br.ReadUInt16();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            bw.WriteUInt32((uint) m_direction);
            bw.WriteUInt32(0);
            s.WriteClassPointer(bw, m_simulationBuffer);
            m_simulationParticleSelection.Write(s, bw);
            s.WriteClassPointer(bw, m_displayBuffer);
            m_displayVertexSelection.Write(s, bw);
            bw.WriteSingle(m_gatherAllThreshold);
            bw.WriteBoolean(m_gatherNormals);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}