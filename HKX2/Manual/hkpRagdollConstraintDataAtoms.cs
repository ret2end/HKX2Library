namespace HKX2
{
    public class hkpRagdollConstraintDataAtoms : IHavokObject
    {
        public enum Axis
        {
            AXIS_TWIST = 0,
            AXIS_PLANES = 1,
            AXIS_CROSS_PRODUCT = 2
        }

        public hkpAngFrictionConstraintAtom m_angFriction;
        public hkpBallSocketConstraintAtom m_ballSocket;
        public hkpConeLimitConstraintAtom m_coneLimit;
        public hkpConeLimitConstraintAtom m_planesLimit;
        public hkpRagdollMotorConstraintAtom m_ragdollMotors;
        public hkpSetupStabilizationAtom m_setupStabilization;

        public hkpSetLocalTransformsConstraintAtom m_transforms;
        public hkpTwistLimitConstraintAtom m_twistLimit;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
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
            m_coneLimit = new hkpConeLimitConstraintAtom();
            m_coneLimit.Read(des, br);
            m_planesLimit = new hkpConeLimitConstraintAtom();
            m_planesLimit.Read(des, br);
            m_ballSocket = new hkpBallSocketConstraintAtom();
            m_ballSocket.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_transforms.Write(s, bw);
            m_setupStabilization.Write(s, bw);
            m_ragdollMotors.Write(s, bw);
            m_angFriction.Write(s, bw);
            m_twistLimit.Write(s, bw);
            m_coneLimit.Write(s, bw);
            m_planesLimit.Write(s, bw);
            m_ballSocket.Write(s, bw);
        }
    }
}