namespace HKX2
{
    public class hkpStiffSpringConstraintDataAtoms : IHavokObject
    {
        public hkpSetLocalTranslationsConstraintAtom m_pivots;
        public hkpSetupStabilizationAtom m_setupStabilization;
        public hkpStiffSpringConstraintAtom m_spring;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_pivots = new hkpSetLocalTranslationsConstraintAtom();
            m_pivots.Read(des, br);
            m_setupStabilization = new hkpSetupStabilizationAtom();
            m_setupStabilization.Read(des, br);
            m_spring = new hkpStiffSpringConstraintAtom();
            m_spring.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_pivots.Write(s, bw);
            m_setupStabilization.Write(s, bw);
            m_spring.Write(s, bw);
        }
    }
}