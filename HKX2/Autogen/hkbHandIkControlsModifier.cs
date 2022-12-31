using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbHandIkControlsModifier Signatire: 0x9f0488bb size: 96 flags: FLAGS_NONE

    // m_hands m_class: hkbHandIkControlsModifierHand Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    public partial class hkbHandIkControlsModifier : hkbModifier
    {
        public List<hkbHandIkControlsModifierHand> m_hands;

        public override uint Signature => 0x9f0488bb;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_hands = des.ReadClassArray<hkbHandIkControlsModifierHand>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray<hkbHandIkControlsModifierHand>(bw, m_hands);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkbHandIkControlsModifierHand>(xe, nameof(m_hands), m_hands);
        }
    }
}

