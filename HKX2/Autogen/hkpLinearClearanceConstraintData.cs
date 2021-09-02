namespace HKX2
{
    public class hkpLinearClearanceConstraintData : hkpConstraintData
    {
        public enum Type
        {
            PRISMATIC = 0,
            HINGE = 1,
            BALL_SOCKET = 2
        }

        public hkpLinearClearanceConstraintDataAtoms m_atoms;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            m_atoms = new hkpLinearClearanceConstraintDataAtoms();
            m_atoms.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            m_atoms.Write(s, bw);
        }
    }
}