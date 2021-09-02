namespace HKX2
{
    public class hkpBridgeAtoms : IHavokObject
    {
        public hkpBridgeConstraintAtom m_bridgeAtom;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_bridgeAtom = new hkpBridgeConstraintAtom();
            m_bridgeAtom.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_bridgeAtom.Write(s, bw);
        }
    }
}