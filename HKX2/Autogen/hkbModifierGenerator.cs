using System.Xml.Linq;

namespace HKX2
{
    // hkbModifierGenerator Signatire: 0x1f81fae6 size: 88 flags: FLAGS_NONE

    // m_modifier m_class: hkbModifier Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 72 flags: FLAGS_NONE enum: 
    // m_generator m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    public partial class hkbModifierGenerator : hkbGenerator
    {
        public hkbModifier m_modifier;
        public hkbGenerator m_generator;

        public override uint Signature => 0x1f81fae6;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_modifier = des.ReadClassPointer<hkbModifier>(br);
            m_generator = des.ReadClassPointer<hkbGenerator>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_modifier);
            s.WriteClassPointer(bw, m_generator);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_modifier), m_modifier);
            xs.WriteClassPointer(xe, nameof(m_generator), m_generator);
        }
    }
}

