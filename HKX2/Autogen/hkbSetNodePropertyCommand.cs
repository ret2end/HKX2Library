using System.Xml.Linq;

namespace HKX2
{
    // hkbSetNodePropertyCommand Signatire: 0xc5160b64 size: 48 flags: FLAGS_NONE

    // m_characterId m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_nodeName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_propertyName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_propertyValue m_class: hkbVariableValue Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_padding m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 44 flags: FLAGS_NONE enum: 
    public partial class hkbSetNodePropertyCommand : hkReferencedObject
    {
        public ulong m_characterId;
        public string m_nodeName;
        public string m_propertyName;
        public hkbVariableValue m_propertyValue;
        public int m_padding;

        public override uint Signature => 0xc5160b64;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_characterId = br.ReadUInt64();
            m_nodeName = des.ReadStringPointer(br);
            m_propertyName = des.ReadStringPointer(br);
            m_propertyValue = new hkbVariableValue();
            m_propertyValue.Read(des, br);
            m_padding = br.ReadInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(m_characterId);
            s.WriteStringPointer(bw, m_nodeName);
            s.WriteStringPointer(bw, m_propertyName);
            m_propertyValue.Write(s, bw);
            bw.WriteInt32(m_padding);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_characterId), m_characterId);
            xs.WriteString(xe, nameof(m_nodeName), m_nodeName);
            xs.WriteString(xe, nameof(m_propertyName), m_propertyName);
            xs.WriteClass<hkbVariableValue>(xe, nameof(m_propertyValue), m_propertyValue);
            xs.WriteNumber(xe, nameof(m_padding), m_padding);
        }
    }
}

