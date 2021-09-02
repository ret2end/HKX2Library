namespace HKX2
{
    public class hkpAngMotorConstraintAtom : hkpConstraintAtom
    {
        public bool m_isEnabled;
        public hkpConstraintMotor m_motor;
        public byte m_motorAxis;
        public float m_targetAngle;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_isEnabled = br.ReadBoolean();
            m_motorAxis = br.ReadByte();
            br.ReadInt16(); // initializedOffset
            br.ReadInt16(); // previousTargetAngleOffset
            m_motor = des.ReadClassPointer<hkpConstraintMotor>(br);
            br.Pad(16); // ?
            m_targetAngle = br.ReadSingle();
            br.ReadInt16(); // correspondingAngLimitSolverResultOffset
            br.ReadBytes(10); // padding
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteBoolean(m_isEnabled);
            bw.WriteByte(m_motorAxis);
            bw.WriteInt16(0); // initializedOffset
            bw.WriteInt16(0); // previousTargetAngleOffset
            s.WriteClassPointer(bw, m_motor);
            bw.Pad(16); // ?
            bw.WriteSingle(m_targetAngle);
            bw.WriteInt16(0); // correspondingAngLimitSolverResultOffset
            bw.WriteBytes(new byte[10]); // padding
        }
    }
}