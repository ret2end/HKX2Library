using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbHandIkModifier Signatire: 0xef8bc2f7 size: 120 flags: FLAGS_NONE

    // m_hands m_class: hkbHandIkModifierHand Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_fadeInOutCurve m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 96 flags: FLAGS_NONE enum: BlendCurve
    // m_internalHandData m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 104 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbHandIkModifier : hkbModifier
    {
        public List<hkbHandIkModifierHand> m_hands;
        public sbyte m_fadeInOutCurve;
        public List<dynamic> m_internalHandData;

        public override uint Signature => 0xef8bc2f7;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_hands = des.ReadClassArray<hkbHandIkModifierHand>(br);
            m_fadeInOutCurve = br.ReadSByte();
            br.Position += 7;
            des.ReadEmptyArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray<hkbHandIkModifierHand>(bw, m_hands);
            s.WriteSByte(bw, m_fadeInOutCurve);
            bw.Position += 7;
            s.WriteVoidArray(bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkbHandIkModifierHand>(xe, nameof(m_hands), m_hands);
            xs.WriteEnum<BlendCurve, sbyte>(xe, nameof(m_fadeInOutCurve), m_fadeInOutCurve);
            xs.WriteSerializeIgnored(xe, nameof(m_internalHandData));
        }
    }
}

