using System.Xml.Linq;

namespace HKX2
{
    // hkpPointToPlaneConstraintDataAtoms Signatire: 0x749bc260 size: 160 flags: FLAGS_NONE

    // m_transforms m_class: hkpSetLocalTransformsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_lin m_class: hkpLinConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 144 flags: FLAGS_NONE enum: 
    public partial class hkpPointToPlaneConstraintDataAtoms : IHavokObject
    {
        public hkpSetLocalTransformsConstraintAtom m_transforms;
        public hkpLinConstraintAtom m_lin;

        public virtual uint Signature => 0x749bc260;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_transforms = new hkpSetLocalTransformsConstraintAtom();
            m_transforms.Read(des, br);
            m_lin = new hkpLinConstraintAtom();
            m_lin.Read(des, br);
            br.Position += 12;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_transforms.Write(s, bw);
            m_lin.Write(s, bw);
            bw.Position += 12;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClass<hkpSetLocalTransformsConstraintAtom>(xe, nameof(m_transforms), m_transforms);
            xs.WriteClass<hkpLinConstraintAtom>(xe, nameof(m_lin), m_lin);
        }
    }
}

