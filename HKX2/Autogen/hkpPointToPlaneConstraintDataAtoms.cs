namespace HKX2
{
    public class hkpPointToPlaneConstraintDataAtoms : IHavokObject
    {
        public hkpLinConstraintAtom m_lin;

        public hkpSetLocalTransformsConstraintAtom m_transforms;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_transforms = new hkpSetLocalTransformsConstraintAtom();
            m_transforms.Read(des, br);
            m_lin = new hkpLinConstraintAtom();
            m_lin.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_transforms.Write(s, bw);
            m_lin.Write(s, bw);
        }
    }
}