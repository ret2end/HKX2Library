namespace HKX2
{
    public class hclStandardLinkConstraintSetMxSingle : IHavokObject
    {
        public ushort m_particleA;
        public ushort m_particleB;

        public float m_restLength;
        public float m_stiffnessA;
        public float m_stiffnessB;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_restLength = br.ReadSingle();
            m_stiffnessA = br.ReadSingle();
            m_stiffnessB = br.ReadSingle();
            m_particleA = br.ReadUInt16();
            m_particleB = br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_restLength);
            bw.WriteSingle(m_stiffnessA);
            bw.WriteSingle(m_stiffnessB);
            bw.WriteUInt16(m_particleA);
            bw.WriteUInt16(m_particleB);
        }
    }
}