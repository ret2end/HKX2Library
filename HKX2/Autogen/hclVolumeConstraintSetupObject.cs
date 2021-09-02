namespace HKX2
{
    public class hclVolumeConstraintSetupObject : hclConstraintSetSetupObject
    {
        public hclVertexSelectionInput m_applyToParticles;
        public hclVertexSelectionInput m_influenceParticles;

        public string m_name;
        public hclVertexFloatInput m_particleWeights;
        public hclSimulationSetupMesh m_simulationMesh;
        public hclVertexFloatInput m_stiffness;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_simulationMesh = des.ReadClassPointer<hclSimulationSetupMesh>(br);
            m_applyToParticles = new hclVertexSelectionInput();
            m_applyToParticles.Read(des, br);
            m_stiffness = new hclVertexFloatInput();
            m_stiffness.Read(des, br);
            m_influenceParticles = new hclVertexSelectionInput();
            m_influenceParticles.Read(des, br);
            m_particleWeights = new hclVertexFloatInput();
            m_particleWeights.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointer(bw, m_simulationMesh);
            m_applyToParticles.Write(s, bw);
            m_stiffness.Write(s, bw);
            m_influenceParticles.Write(s, bw);
            m_particleWeights.Write(s, bw);
        }
    }
}