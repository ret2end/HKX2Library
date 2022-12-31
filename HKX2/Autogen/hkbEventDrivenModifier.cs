using System.Xml.Linq;

namespace HKX2
{
    // hkbEventDrivenModifier Signatire: 0x7ed3f44e size: 104 flags: FLAGS_NONE

    // m_activateEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_deactivateEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 92 flags: FLAGS_NONE enum: 
    // m_activeByDefault m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_isActive m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 97 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbEventDrivenModifier : hkbModifierWrapper
    {
        public int m_activateEventId;
        public int m_deactivateEventId;
        public bool m_activeByDefault;
        public bool m_isActive;

        public override uint Signature => 0x7ed3f44e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_activateEventId = br.ReadInt32();
            m_deactivateEventId = br.ReadInt32();
            m_activeByDefault = br.ReadBoolean();
            m_isActive = br.ReadBoolean();
            br.Position += 6;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteInt32(m_activateEventId);
            bw.WriteInt32(m_deactivateEventId);
            bw.WriteBoolean(m_activeByDefault);
            bw.WriteBoolean(m_isActive);
            bw.Position += 6;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_activateEventId), m_activateEventId);
            xs.WriteNumber(xe, nameof(m_deactivateEventId), m_deactivateEventId);
            xs.WriteBoolean(xe, nameof(m_activeByDefault), m_activeByDefault);
            xs.WriteSerializeIgnored(xe, nameof(m_isActive));
        }
    }
}

