using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbModifierList Signatire: 0xa4180ca1 size: 96 flags: FLAGS_NONE

    // m_modifiers m_class: hkbModifier Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    public partial class hkbModifierList : hkbModifier
    {
        public List<hkbModifier> m_modifiers = new List<hkbModifier>();

        public override uint Signature => 0xa4180ca1;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_modifiers = des.ReadClassPointerArray<hkbModifier>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray<hkbModifier>(bw, m_modifiers);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_modifiers = xd.ReadClassPointerArray<hkbModifier>(xe, nameof(m_modifiers));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray<hkbModifier>(xe, nameof(m_modifiers), m_modifiers);
        }
    }
}

