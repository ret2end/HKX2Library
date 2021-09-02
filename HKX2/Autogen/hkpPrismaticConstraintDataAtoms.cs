namespace HKX2
{
    public class hkpPrismaticConstraintDataAtoms : IHavokObject
    {
        public enum Axis
        {
            AXIS_SHAFT = 0,
            AXIS_PERP_TO_SHAFT = 1
        }

        public hkpAngConstraintAtom m_ang;
        public hkpLinFrictionConstraintAtom m_friction;
        public hkpLinConstraintAtom m_lin0;
        public hkpLinConstraintAtom m_lin1;
        public hkpLinLimitConstraintAtom m_linLimit;
        public hkpLinMotorConstraintAtom m_motor;

        public hkpSetLocalTransformsConstraintAtom m_transforms;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_transforms = new hkpSetLocalTransformsConstraintAtom();
            m_transforms.Read(des, br);
            m_motor = new hkpLinMotorConstraintAtom();
            m_motor.Read(des, br);
            m_friction = new hkpLinFrictionConstraintAtom();
            m_friction.Read(des, br);
            m_ang = new hkpAngConstraintAtom();
            m_ang.Read(des, br);
            m_lin0 = new hkpLinConstraintAtom();
            m_lin0.Read(des, br);
            m_lin1 = new hkpLinConstraintAtom();
            m_lin1.Read(des, br);
            m_linLimit = new hkpLinLimitConstraintAtom();
            m_linLimit.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_transforms.Write(s, bw);
            m_motor.Write(s, bw);
            m_friction.Write(s, bw);
            m_ang.Write(s, bw);
            m_lin0.Write(s, bw);
            m_lin1.Write(s, bw);
            m_linLimit.Write(s, bw);
        }
    }
}