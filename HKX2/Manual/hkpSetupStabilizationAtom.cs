namespace HKX2
{
    public class hkpSetupStabilizationAtom : hkpConstraintAtom
    {
        public bool m_enabled;
        public float m_maxAngImpulse;
        public float m_maxAngle;
        public float m_maxLinImpulse;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_enabled = br.ReadBoolean();
            br.ReadByte(); // padding
            m_maxLinImpulse = br.ReadSingle();
            m_maxAngImpulse = br.ReadSingle();
            m_maxAngle = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteBoolean(m_enabled);
            bw.WriteByte(0); // padding
            bw.WriteSingle(m_maxLinImpulse);
            bw.WriteSingle(m_maxAngImpulse);
            bw.WriteSingle(m_maxAngle);
        }
    }
}