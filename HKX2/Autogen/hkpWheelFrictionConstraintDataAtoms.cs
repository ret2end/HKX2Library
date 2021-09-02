namespace HKX2
{
    public class hkpWheelFrictionConstraintDataAtoms : IHavokObject
    {
        public hkpWheelFrictionConstraintAtom m_friction;

        public hkpSetLocalTransformsConstraintAtom m_transforms;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_transforms = new hkpSetLocalTransformsConstraintAtom();
            m_transforms.Read(des, br);
            m_friction = new hkpWheelFrictionConstraintAtom();
            m_friction.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_transforms.Write(s, bw);
            m_friction.Write(s, bw);
        }
    }
}