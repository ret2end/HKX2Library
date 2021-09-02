namespace HKX2
{
    public class hkpEllipticalLimitConstraintAtom : hkpConstraintAtom
    {
        public float m_angle0;
        public float m_angle1;
        public float m_angleCorrected0;
        public float m_angleCorrected0Inv;
        public float m_angleCorrected1;
        public float m_angleCorrected1Inv;
        public float m_angularLimitsDampFactor;
        public float m_angularLimitsTauFactor;
        public float m_coneAngle;
        public float m_coneAngleCorrected;
        public bool m_coneLimitEnabled;
        public bool m_elipticalLimitEnabled;

        public byte m_isEnabled;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_isEnabled = br.ReadByte();
            m_elipticalLimitEnabled = br.ReadBoolean();
            m_coneLimitEnabled = br.ReadBoolean();
            br.ReadUInt16();
            br.ReadByte();
            m_angle0 = br.ReadSingle();
            m_angle1 = br.ReadSingle();
            m_coneAngle = br.ReadSingle();
            m_angleCorrected0 = br.ReadSingle();
            m_angleCorrected1 = br.ReadSingle();
            m_coneAngleCorrected = br.ReadSingle();
            m_angleCorrected0Inv = br.ReadSingle();
            m_angleCorrected1Inv = br.ReadSingle();
            m_angularLimitsTauFactor = br.ReadSingle();
            m_angularLimitsDampFactor = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteByte(m_isEnabled);
            bw.WriteBoolean(m_elipticalLimitEnabled);
            bw.WriteBoolean(m_coneLimitEnabled);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            bw.WriteSingle(m_angle0);
            bw.WriteSingle(m_angle1);
            bw.WriteSingle(m_coneAngle);
            bw.WriteSingle(m_angleCorrected0);
            bw.WriteSingle(m_angleCorrected1);
            bw.WriteSingle(m_coneAngleCorrected);
            bw.WriteSingle(m_angleCorrected0Inv);
            bw.WriteSingle(m_angleCorrected1Inv);
            bw.WriteSingle(m_angularLimitsTauFactor);
            bw.WriteSingle(m_angularLimitsDampFactor);
        }
    }
}