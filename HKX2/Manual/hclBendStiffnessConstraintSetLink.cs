namespace HKX2
{
    public class hclBendStiffnessConstraintSetLink : IHavokObject
    {
        public float m_bendStiffness;
        public ushort m_particleA;
        public ushort m_particleB;
        public ushort m_particleC;
        public ushort m_particleD;
        public float m_restCurvature;

        public float m_weightA;
        public float m_weightB;
        public float m_weightC;
        public float m_weightD;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_weightA = br.ReadSingle();
            m_weightB = br.ReadSingle();
            m_weightC = br.ReadSingle();
            m_weightD = br.ReadSingle();
            m_bendStiffness = br.ReadSingle();
            m_restCurvature = br.ReadSingle();
            m_particleA = br.ReadUInt16();
            m_particleB = br.ReadUInt16();
            m_particleC = br.ReadUInt16();
            m_particleD = br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_weightA);
            bw.WriteSingle(m_weightB);
            bw.WriteSingle(m_weightC);
            bw.WriteSingle(m_weightD);
            bw.WriteSingle(m_bendStiffness);
            bw.WriteSingle(m_restCurvature);
            bw.WriteUInt16(m_particleA);
            bw.WriteUInt16(m_particleB);
            bw.WriteUInt16(m_particleC);
            bw.WriteUInt16(m_particleD);
        }
    }
}