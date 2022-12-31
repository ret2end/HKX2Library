using System.Xml.Linq;

namespace HKX2
{
    // hkbHandIkControlsModifierHand Signatire: 0x9c72e9e3 size: 112 flags: FLAGS_NONE

    // m_controlData m_class: hkbHandIkControlData Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_handIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_enable m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 100 flags: FLAGS_NONE enum: 
    public partial class hkbHandIkControlsModifierHand : IHavokObject
    {
        public hkbHandIkControlData m_controlData;
        public int m_handIndex;
        public bool m_enable;

        public virtual uint Signature => 0x9c72e9e3;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_controlData = new hkbHandIkControlData();
            m_controlData.Read(des, br);
            m_handIndex = br.ReadInt32();
            m_enable = br.ReadBoolean();
            br.Position += 11;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_controlData.Write(s, bw);
            bw.WriteInt32(m_handIndex);
            bw.WriteBoolean(m_enable);
            bw.Position += 11;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClass<hkbHandIkControlData>(xe, nameof(m_controlData), m_controlData);
            xs.WriteNumber(xe, nameof(m_handIndex), m_handIndex);
            xs.WriteBoolean(xe, nameof(m_enable), m_enable);
        }
    }
}

