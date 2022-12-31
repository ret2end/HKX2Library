using System.Xml.Linq;

namespace HKX2
{
    // hkpStiffSpringConstraintData Signatire: 0xb98f66f4 size: 96 flags: FLAGS_NONE

    // m_atoms m_class: hkpStiffSpringConstraintDataAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 32 flags: ALIGN_16|FLAGS_NONE enum: 
    public partial class hkpStiffSpringConstraintData : hkpConstraintData
    {
        public hkpStiffSpringConstraintDataAtoms m_atoms;

        public override uint Signature => 0xb98f66f4;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 8;
            m_atoms = new hkpStiffSpringConstraintDataAtoms();
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

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkpStiffSpringConstraintDataAtoms>(xe, nameof(m_atoms), m_atoms);
        }
    }
}

