namespace HKX2
{
    public class hkpRackAndPinionConstraintDataAtoms : IHavokObject
    {
        public hkpRackAndPinionConstraintAtom m_rackAndPinion;

        public hkpSetLocalTransformsConstraintAtom m_transforms;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_transforms = new hkpSetLocalTransformsConstraintAtom();
            m_transforms.Read(des, br);
            m_rackAndPinion = new hkpRackAndPinionConstraintAtom();
            m_rackAndPinion.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_transforms.Write(s, bw);
            m_rackAndPinion.Write(s, bw);
        }
    }
}