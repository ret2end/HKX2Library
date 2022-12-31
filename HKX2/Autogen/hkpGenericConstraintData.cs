using System.Xml.Linq;

namespace HKX2
{
    // hkpGenericConstraintData Signatire: 0xfa824640 size: 128 flags: FLAGS_NONE

    // m_atoms m_class: hkpBridgeAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_scheme m_class: hkpGenericConstraintDataScheme Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    public partial class hkpGenericConstraintData : hkpConstraintData
    {
        public hkpBridgeAtoms m_atoms;
        public hkpGenericConstraintDataScheme m_scheme;

        public override uint Signature => 0xfa824640;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_atoms = new hkpBridgeAtoms();
            m_atoms.Read(des, br);
            m_scheme = new hkpGenericConstraintDataScheme();
            m_scheme.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_atoms.Write(s, bw);
            m_scheme.Write(s, bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkpBridgeAtoms>(xe, nameof(m_atoms), m_atoms);
            xs.WriteClass<hkpGenericConstraintDataScheme>(xe, nameof(m_scheme), m_scheme);
        }
    }
}

