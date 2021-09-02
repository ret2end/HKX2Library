namespace HKX2
{
    public class hkpTwistLimitConstraintAtom : hkpConstraintAtom
    {
        public float m_angularLimitsDampFactor;
        public float m_angularLimitsTauFactor;

        public byte m_isEnabled;
        public float m_maxAngle;
        public float m_minAngle;
        public byte m_refAxis;
        public byte m_twistAxis;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_isEnabled = br.ReadByte();
            m_twistAxis = br.ReadByte();
            m_refAxis = br.ReadByte();
            br.ReadByte();
            br.ReadUInt16();
            m_minAngle = br.ReadSingle();
            m_maxAngle = br.ReadSingle();
            m_angularLimitsTauFactor = br.ReadSingle();
            m_angularLimitsDampFactor = br.ReadSingle();
            br.ReadUInt64(); // padding_0,1,2,3,4,5,6,7
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteByte(m_isEnabled);
            bw.WriteByte(m_twistAxis);
            bw.WriteByte(m_refAxis);
            bw.WriteByte(0);
            bw.WriteUInt16(0);
            bw.WriteSingle(m_minAngle);
            bw.WriteSingle(m_maxAngle);
            bw.WriteSingle(m_angularLimitsTauFactor);
            bw.WriteSingle(m_angularLimitsDampFactor);
            bw.WriteUInt64(0); // padding_0,1,2,3,4,5,6,7
        }
    }
}