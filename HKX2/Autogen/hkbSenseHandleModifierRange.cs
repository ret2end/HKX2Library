using System.Xml.Linq;

namespace HKX2
{
    // hkbSenseHandleModifierRange Signatire: 0xfb56b692 size: 32 flags: FLAGS_NONE

    // m_event m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_minDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_maxDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 20 flags: FLAGS_NONE enum: 
    // m_ignoreHandle m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    public partial class hkbSenseHandleModifierRange : IHavokObject
    {
        public hkbEventProperty m_event;
        public float m_minDistance;
        public float m_maxDistance;
        public bool m_ignoreHandle;

        public virtual uint Signature => 0xfb56b692;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_event = new hkbEventProperty();
            m_event.Read(des, br);
            m_minDistance = br.ReadSingle();
            m_maxDistance = br.ReadSingle();
            m_ignoreHandle = br.ReadBoolean();
            br.Position += 7;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_event.Write(s, bw);
            bw.WriteSingle(m_minDistance);
            bw.WriteSingle(m_maxDistance);
            bw.WriteBoolean(m_ignoreHandle);
            bw.Position += 7;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClass<hkbEventProperty>(xe, nameof(m_event), m_event);
            xs.WriteFloat(xe, nameof(m_minDistance), m_minDistance);
            xs.WriteFloat(xe, nameof(m_maxDistance), m_maxDistance);
            xs.WriteBoolean(xe, nameof(m_ignoreHandle), m_ignoreHandle);
        }
    }
}

