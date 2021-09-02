namespace HKX2
{
    public class hkpLimitedForceConstraintMotor : hkpConstraintMotor
    {
        public float m_maxForce;

        public float m_minForce;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_minForce = br.ReadSingle();
            m_maxForce = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_minForce);
            bw.WriteSingle(m_maxForce);
        }
    }
}