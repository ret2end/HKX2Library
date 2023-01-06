using System.Xml.Linq;

namespace HKX2
{
    // hkpHingeLimitsData Signatire: 0xbd46760a size: 176 flags: FLAGS_NONE

    // m_atoms m_class: hkpHingeLimitsDataAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 32 flags: ALIGN_16|FLAGS_NONE enum: 
    public partial class hkpHingeLimitsData : hkpConstraintData
    {
        public hkpHingeLimitsDataAtoms m_atoms = new hkpHingeLimitsDataAtoms();

        public override uint Signature => 0xbd46760a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 8;
            m_atoms = new hkpHingeLimitsDataAtoms();
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
            m_atoms = xd.ReadClass<hkpHingeLimitsDataAtoms>(xe, nameof(m_atoms));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkpHingeLimitsDataAtoms>(xe, nameof(m_atoms), m_atoms);
        }
    }
}

