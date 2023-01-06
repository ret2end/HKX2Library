using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbAttributeModifier Signatire: 0x1245d97d size: 96 flags: FLAGS_NONE

    // m_assignments m_class: hkbAttributeModifierAssignment Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    public partial class hkbAttributeModifier : hkbModifier
    {
        public List<hkbAttributeModifierAssignment> m_assignments = new List<hkbAttributeModifierAssignment>();

        public override uint Signature => 0x1245d97d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_assignments = des.ReadClassArray<hkbAttributeModifierAssignment>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray<hkbAttributeModifierAssignment>(bw, m_assignments);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_assignments = xd.ReadClassArray<hkbAttributeModifierAssignment>(xe, nameof(m_assignments));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkbAttributeModifierAssignment>(xe, nameof(m_assignments), m_assignments);
        }
    }
}

