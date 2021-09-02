namespace HKX2
{
    public class hkpSpringDamperConstraintMotor : hkpLimitedForceConstraintMotor
    {
        public float m_springConstant;
        public float m_springDamping;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_springConstant = br.ReadSingle();
            m_springDamping = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_springConstant);
            bw.WriteSingle(m_springDamping);
        }
    }
}