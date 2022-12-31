using System.Xml.Linq;

namespace HKX2
{
    // hkpRackAndPinionConstraintDataAtoms Signatire: 0xa58a9659 size: 160 flags: FLAGS_NONE

    // m_transforms m_class: hkpSetLocalTransformsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_rackAndPinion m_class: hkpRackAndPinionConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 144 flags: FLAGS_NONE enum: 
    public partial class hkpRackAndPinionConstraintDataAtoms : IHavokObject
    {
        public hkpSetLocalTransformsConstraintAtom m_transforms;
        public hkpRackAndPinionConstraintAtom m_rackAndPinion;

        public virtual uint Signature => 0xa58a9659;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_transforms = new hkpSetLocalTransformsConstraintAtom();
            m_transforms.Read(des, br);
            m_rackAndPinion = new hkpRackAndPinionConstraintAtom();
            m_rackAndPinion.Read(des, br);
            br.Position += 4;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_transforms.Write(s, bw);
            m_rackAndPinion.Write(s, bw);
            bw.Position += 4;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClass<hkpSetLocalTransformsConstraintAtom>(xe, nameof(m_transforms), m_transforms);
            xs.WriteClass<hkpRackAndPinionConstraintAtom>(xe, nameof(m_rackAndPinion), m_rackAndPinion);
        }
    }
}

