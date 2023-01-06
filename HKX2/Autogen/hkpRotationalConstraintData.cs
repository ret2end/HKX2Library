using System.Xml.Linq;

namespace HKX2
{
    // hkpRotationalConstraintData Signatire: 0x74867d9e size: 160 flags: FLAGS_NONE

    // m_atoms m_class: hkpRotationalConstraintDataAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 32 flags: ALIGN_16|FLAGS_NONE enum: 
    public partial class hkpRotationalConstraintData : hkpConstraintData
    {
        public hkpRotationalConstraintDataAtoms m_atoms = new hkpRotationalConstraintDataAtoms();

        public override uint Signature => 0x74867d9e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 8;
            m_atoms = new hkpRotationalConstraintDataAtoms();
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
            m_atoms = xd.ReadClass<hkpRotationalConstraintDataAtoms>(xe, nameof(m_atoms));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkpRotationalConstraintDataAtoms>(xe, nameof(m_atoms), m_atoms);
        }
    }
}

