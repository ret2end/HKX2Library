using System.Xml.Linq;

namespace HKX2
{
    // hkbBehaviorInfoIdToNamePair Signatire: 0x35a0439a size: 24 flags: FLAGS_NONE

    // m_behaviorName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_nodeName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_toolType m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 16 flags: FLAGS_NONE enum: ToolNodeType
    // m_id m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 18 flags: FLAGS_NONE enum: 
    public partial class hkbBehaviorInfoIdToNamePair : IHavokObject
    {
        public string m_behaviorName;
        public string m_nodeName;
        public byte m_toolType;
        public short m_id;

        public virtual uint Signature => 0x35a0439a;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_behaviorName = des.ReadStringPointer(br);
            m_nodeName = des.ReadStringPointer(br);
            m_toolType = br.ReadByte();
            br.Position += 1;
            m_id = br.ReadInt16();
            br.Position += 4;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_behaviorName);
            s.WriteStringPointer(bw, m_nodeName);
            s.WriteByte(bw, m_toolType);
            bw.Position += 1;
            bw.WriteInt16(m_id);
            bw.Position += 4;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteString(xe, nameof(m_behaviorName), m_behaviorName);
            xs.WriteString(xe, nameof(m_nodeName), m_nodeName);
            xs.WriteEnum<ToolNodeType, byte>(xe, nameof(m_toolType), m_toolType);
            xs.WriteNumber(xe, nameof(m_id), m_id);
        }
    }
}

