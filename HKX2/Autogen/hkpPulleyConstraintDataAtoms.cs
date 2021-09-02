namespace HKX2
{
    public class hkpPulleyConstraintDataAtoms : IHavokObject
    {
        public hkpPulleyConstraintAtom m_pulley;

        public hkpSetLocalTranslationsConstraintAtom m_translations;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_translations = new hkpSetLocalTranslationsConstraintAtom();
            m_translations.Read(des, br);
            m_pulley = new hkpPulleyConstraintAtom();
            m_pulley.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_translations.Write(s, bw);
            m_pulley.Write(s, bw);
        }
    }
}