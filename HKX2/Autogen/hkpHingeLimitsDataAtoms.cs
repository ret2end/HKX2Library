namespace HKX2
{
    public class hkpHingeLimitsDataAtoms : IHavokObject
    {
        public enum Axis
        {
            AXIS_AXLE = 0,
            AXIS_PERP_TO_AXLE_1 = 1,
            AXIS_PERP_TO_AXLE_2 = 2
        }

        public hkp2dAngConstraintAtom m_2dAng;
        public hkpAngLimitConstraintAtom m_angLimit;

        public hkpSetLocalRotationsConstraintAtom m_rotations;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_rotations = new hkpSetLocalRotationsConstraintAtom();
            m_rotations.Read(des, br);
            m_angLimit = new hkpAngLimitConstraintAtom();
            m_angLimit.Read(des, br);
            m_2dAng = new hkp2dAngConstraintAtom();
            m_2dAng.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_rotations.Write(s, bw);
            m_angLimit.Write(s, bw);
            m_2dAng.Write(s, bw);
        }
    }
}