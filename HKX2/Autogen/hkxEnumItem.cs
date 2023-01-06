using System.Xml.Linq;

namespace HKX2
{
    // hkxEnumItem Signatire: 0xdf4cf1e9 size: 16 flags: FLAGS_NONE

    // m_value m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    public partial class hkxEnumItem : IHavokObject
    {
        public int m_value;
        public string m_name;

        public virtual uint Signature => 0xdf4cf1e9;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_value = br.ReadInt32();
            br.Position += 4;
            m_name = des.ReadStringPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_value);
            bw.Position += 4;
            s.WriteStringPointer(bw, m_name);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_value = xd.ReadInt32(xe, nameof(m_value));
            m_name = xd.ReadString(xe, nameof(m_name));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumber(xe, nameof(m_value), m_value);
            xs.WriteString(xe, nameof(m_name), m_name);
        }
    }
}

