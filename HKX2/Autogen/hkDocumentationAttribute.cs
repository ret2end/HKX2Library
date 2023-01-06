using System.Xml.Linq;

namespace HKX2
{
    // hkDocumentationAttribute Signatire: 0x630edd9e size: 8 flags: FLAGS_NONE

    // m_docsSectionTag m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    public partial class hkDocumentationAttribute : IHavokObject
    {
        public string m_docsSectionTag;

        public virtual uint Signature => 0x630edd9e;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_docsSectionTag = des.ReadStringPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteCStringPointer(bw, m_docsSectionTag);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_docsSectionTag = xd.ReadString(xe, nameof(m_docsSectionTag));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteString(xe, nameof(m_docsSectionTag), m_docsSectionTag);
        }
    }
}

