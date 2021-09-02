namespace HKX2
{
    public class hkpVehicleDefaultVelocityDamper : hkpVehicleVelocityDamper
    {
        public float m_collisionSpinDamping;
        public float m_collisionThreshold;

        public float m_normalSpinDamping;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_normalSpinDamping = br.ReadSingle();
            m_collisionSpinDamping = br.ReadSingle();
            m_collisionThreshold = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_normalSpinDamping);
            bw.WriteSingle(m_collisionSpinDamping);
            bw.WriteSingle(m_collisionThreshold);
        }
    }
}