using System.Xml.Linq;

namespace HKX2
{
    // hkpHingeConstraintData Signatire: 0x9590f046 size: 224 flags: FLAGS_NONE

    // m_atoms m_class: hkpHingeConstraintDataAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 32 flags: ALIGN_16|FLAGS_NONE enum: 
    public partial class hkpHingeConstraintData : hkpConstraintData
    {
        public hkpHingeConstraintDataAtoms m_atoms = new hkpHingeConstraintDataAtoms();

        public override uint Signature => 0x9590f046;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 8;
            m_atoms = new hkpHingeConstraintDataAtoms();
            m_atoms.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 8;
            m_atoms.Write(s, bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_atoms = xd.ReadClass<hkpHingeConstraintDataAtoms>(xe, nameof(m_atoms));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkpHingeConstraintDataAtoms>(xe, nameof(m_atoms), m_atoms);
        }
    }
}

