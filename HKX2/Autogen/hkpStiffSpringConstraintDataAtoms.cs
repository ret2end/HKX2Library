using System.Xml.Linq;

namespace HKX2
{
    // hkpStiffSpringConstraintDataAtoms Signatire: 0x207eb376 size: 64 flags: FLAGS_NONE

    // m_pivots m_class: hkpSetLocalTranslationsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_spring m_class: hkpStiffSpringConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    public partial class hkpStiffSpringConstraintDataAtoms : IHavokObject
    {
        public hkpSetLocalTranslationsConstraintAtom m_pivots;
        public hkpStiffSpringConstraintAtom m_spring;

        public virtual uint Signature => 0x207eb376;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_pivots = new hkpSetLocalTranslationsConstraintAtom();
            m_pivots.Read(des, br);
            m_spring = new hkpStiffSpringConstraintAtom();
            m_spring.Read(des, br);
            br.Position += 8;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_pivots.Write(s, bw);
            m_spring.Write(s, bw);
            bw.Position += 8;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClass<hkpSetLocalTranslationsConstraintAtom>(xe, nameof(m_pivots), m_pivots);
            xs.WriteClass<hkpStiffSpringConstraintAtom>(xe, nameof(m_spring), m_spring);
        }
    }
}

