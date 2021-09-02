namespace HKX2
{
    public class hkpAngLimitConstraintAtom : hkpConstraintAtom
    {
        public float m_angularLimitsDampFactor;
        public float m_angularLimitsTauFactor;
        public byte m_cosineAxis;

        public byte m_isEnabled;
        public byte m_limitAxis;
        public float m_maxAngle;
        public float m_minAngle;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_isEnabled = br.ReadByte();
            m_limitAxis = br.ReadByte();
            m_cosineAxis = br.ReadByte();
            br.ReadBytes(3); // padding2
            m_minAngle = br.ReadSingle();
            m_maxAngle = br.ReadSingle();
            m_angularLimitsTauFactor = br.ReadSingle();
            m_angularLimitsDampFactor = br.ReadSingle();
            br.ReadBytes(8); // padding
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteByte(m_isEnabled);
            bw.WriteByte(m_limitAxis);
            bw.WriteByte(m_cosineAxis);
            bw.WriteBytes(new byte[3]); // padding2
            bw.WriteSingle(m_minAngle);
            bw.WriteSingle(m_maxAngle);
            bw.WriteSingle(m_angularLimitsTauFactor);
            bw.WriteSingle(m_angularLimitsDampFactor);
            bw.WriteBytes(new byte[8]); // padding
        }
    }
}