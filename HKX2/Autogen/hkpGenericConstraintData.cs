namespace HKX2
{
    public class hkpGenericConstraintData : hkpConstraintData
    {
        public hkpBridgeAtoms m_atoms;
        public hkpGenericConstraintDataScheme m_scheme;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            m_atoms = new hkpBridgeAtoms();
            m_atoms.Read(des, br);
            m_scheme = new hkpGenericConstraintDataScheme();
            m_scheme.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            m_atoms.Write(s, bw);
            m_scheme.Write(s, bw);
        }
    }
}