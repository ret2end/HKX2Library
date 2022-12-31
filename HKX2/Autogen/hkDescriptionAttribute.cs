using System.Xml.Linq;

namespace HKX2
{
    // hkDescriptionAttribute Signatire: 0xe9f9578a size: 8 flags: FLAGS_NONE

    // m_string m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    public partial class hkDescriptionAttribute : IHavokObject
    {
        public string m_string;

        public virtual uint Signature => 0xe9f9578a;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_string = des.ReadStringPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_string);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteString(xe, nameof(m_string), m_string);
        }
    }
}

