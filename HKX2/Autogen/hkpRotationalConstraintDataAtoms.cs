namespace HKX2
{
    public class hkpRotationalConstraintDataAtoms : IHavokObject
    {
        public hkpAngConstraintAtom m_ang;

        public hkpSetLocalRotationsConstraintAtom m_rotations;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_rotations = new hkpSetLocalRotationsConstraintAtom();
            m_rotations.Read(des, br);
            m_ang = new hkpAngConstraintAtom();
            m_ang.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_rotations.Write(s, bw);
            m_ang.Write(s, bw);
        }
    }
}