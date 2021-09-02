namespace HKX2
{
    public class hkpRagdollConstraintData : hkpConstraintData
    {
        public hkpRagdollConstraintDataAtoms m_atoms;
        public override uint Signature => 0xED9648F7;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Pad(16);
            m_atoms = new hkpRagdollConstraintDataAtoms();
            m_atoms.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Pad(16);
            m_atoms.Write(s, bw);
        }
    }
}