namespace HKX2
{
    public class hkpVehicleDefaultSuspensionWheelSpringSuspensionParameters : IHavokObject
    {
        public float m_dampingCompression;
        public float m_dampingRelaxation;

        public float m_strength;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_strength = br.ReadSingle();
            m_dampingCompression = br.ReadSingle();
            m_dampingRelaxation = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_strength);
            bw.WriteSingle(m_dampingCompression);
            bw.WriteSingle(m_dampingRelaxation);
        }
    }
}