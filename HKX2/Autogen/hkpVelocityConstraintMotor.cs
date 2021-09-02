namespace HKX2
{
    public class hkpVelocityConstraintMotor : hkpLimitedForceConstraintMotor
    {
        public float m_tau;
        public bool m_useVelocityTargetFromConstraintTargets;
        public float m_velocityTarget;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_tau = br.ReadSingle();
            m_velocityTarget = br.ReadSingle();
            m_useVelocityTargetFromConstraintTargets = br.ReadBoolean();
            br.ReadUInt32();
            br.ReadUInt16();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_tau);
            bw.WriteSingle(m_velocityTarget);
            bw.WriteBoolean(m_useVelocityTargetFromConstraintTargets);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}