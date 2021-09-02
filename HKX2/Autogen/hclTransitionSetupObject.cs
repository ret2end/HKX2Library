namespace HKX2
{
    public class hclTransitionSetupObject : hclConstraintSetSetupObject
    {
        public string m_name;
        public hclBufferSetupObject m_referenceBufferSetup;
        public hclSimulationSetupMesh m_simulationMesh;
        public hclVertexFloatInput m_toAnimDelay;
        public float m_toAnimPeriod;
        public hclVertexFloatInput m_toSimDelay;
        public hclVertexFloatInput m_toSimMaxDistance;
        public float m_toSimPeriod;
        public hclVertexSelectionInput m_vertexSelection;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_simulationMesh = des.ReadClassPointer<hclSimulationSetupMesh>(br);
            m_vertexSelection = new hclVertexSelectionInput();
            m_vertexSelection.Read(des, br);
            m_toAnimDelay = new hclVertexFloatInput();
            m_toAnimDelay.Read(des, br);
            m_toSimDelay = new hclVertexFloatInput();
            m_toSimDelay.Read(des, br);
            m_toSimMaxDistance = new hclVertexFloatInput();
            m_toSimMaxDistance.Read(des, br);
            m_toAnimPeriod = br.ReadSingle();
            m_toSimPeriod = br.ReadSingle();
            m_referenceBufferSetup = des.ReadClassPointer<hclBufferSetupObject>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointer(bw, m_simulationMesh);
            m_vertexSelection.Write(s, bw);
            m_toAnimDelay.Write(s, bw);
            m_toSimDelay.Write(s, bw);
            m_toSimMaxDistance.Write(s, bw);
            bw.WriteSingle(m_toAnimPeriod);
            bw.WriteSingle(m_toSimPeriod);
            s.WriteClassPointer(bw, m_referenceBufferSetup);
        }
    }
}