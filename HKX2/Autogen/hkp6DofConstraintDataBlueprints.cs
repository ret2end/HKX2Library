namespace HKX2
{
    public class hkp6DofConstraintDataBlueprints : IHavokObject
    {
        public hkpAngFrictionConstraintAtom m_angFriction;
        public hkpBallSocketConstraintAtom m_ballSocket;
        public hkpEllipticalLimitConstraintAtom m_ellipticalLimit;

        public bool m_linearIsFixed_0;
        public bool m_linearIsFixed_1;
        public bool m_linearIsFixed_2;
        public hkpLinMotorConstraintAtom m_linearMotor0;
        public hkpLinMotorConstraintAtom m_linearMotor1;
        public hkpLinMotorConstraintAtom m_linearMotor2;
        public hkpRagdollMotorConstraintAtom m_ragdollMotors;
        public hkpSetupStabilizationAtom m_setupStabilization;
        public hkpStiffSpringConstraintAtom m_stiffSpring;
        public hkpSetLocalTransformsConstraintAtom m_transforms;
        public hkpTwistLimitConstraintAtom m_twistLimit;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_linearIsFixed_0 = br.ReadBoolean();
            m_linearIsFixed_1 = br.ReadBoolean();
            m_linearIsFixed_2 = br.ReadBoolean();
            br.ReadUInt64();
            br.ReadUInt32();
            br.ReadByte();
            m_transforms = new hkpSetLocalTransformsConstraintAtom();
            m_transforms.Read(des, br);
            m_setupStabilization = new hkpSetupStabilizationAtom();
            m_setupStabilization.Read(des, br);
            m_ragdollMotors = new hkpRagdollMotorConstraintAtom();
            m_ragdollMotors.Read(des, br);
            m_angFriction = new hkpAngFrictionConstraintAtom();
            m_angFriction.Read(des, br);
            m_twistLimit = new hkpTwistLimitConstraintAtom();
            m_twistLimit.Read(des, br);
            m_ellipticalLimit = new hkpEllipticalLimitConstraintAtom();
            m_ellipticalLimit.Read(des, br);
            m_stiffSpring = new hkpStiffSpringConstraintAtom();
            m_stiffSpring.Read(des, br);
            m_linearMotor0 = new hkpLinMotorConstraintAtom();
            m_linearMotor0.Read(des, br);
            m_linearMotor1 = new hkpLinMotorConstraintAtom();
            m_linearMotor1.Read(des, br);
            m_linearMotor2 = new hkpLinMotorConstraintAtom();
            m_linearMotor2.Read(des, br);
            m_ballSocket = new hkpBallSocketConstraintAtom();
            m_ballSocket.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteBoolean(m_linearIsFixed_0);
            bw.WriteBoolean(m_linearIsFixed_1);
            bw.WriteBoolean(m_linearIsFixed_2);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            bw.WriteByte(0);
            m_transforms.Write(s, bw);
            m_setupStabilization.Write(s, bw);
            m_ragdollMotors.Write(s, bw);
            m_angFriction.Write(s, bw);
            m_twistLimit.Write(s, bw);
            m_ellipticalLimit.Write(s, bw);
            m_stiffSpring.Write(s, bw);
            m_linearMotor0.Write(s, bw);
            m_linearMotor1.Write(s, bw);
            m_linearMotor2.Write(s, bw);
            m_ballSocket.Write(s, bw);
        }
    }
}