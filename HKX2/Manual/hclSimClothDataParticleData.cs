namespace HKX2
{
    public class hclSimClothDataParticleData : IHavokObject
    {
        public float m_friction;
        public float m_invMass;

        public float m_mass;
        public float m_radius;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_mass = br.ReadSingle();
            m_invMass = br.ReadSingle();
            m_radius = br.ReadSingle();
            m_friction = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_mass);
            bw.WriteSingle(m_invMass);
            bw.WriteSingle(m_radius);
            bw.WriteSingle(m_friction);
        }
    }
}