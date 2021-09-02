namespace HKX2
{
    public class hkpSoftContactModifierConstraintAtom : hkpModifierConstraintAtom
    {
        public float m_maxAcceleration;

        public float m_tau;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_tau = br.ReadSingle();
            m_maxAcceleration = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_tau);
            bw.WriteSingle(m_maxAcceleration);
        }
    }
}