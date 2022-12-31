using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkxAttributeGroup Signatire: 0x345ca95d size: 24 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_attributes m_class: hkxAttribute Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    public partial class hkxAttributeGroup : IHavokObject
    {
        public string m_name;
        public List<hkxAttribute> m_attributes;

        public virtual uint Signature => 0x345ca95d;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_name = des.ReadStringPointer(br);
            m_attributes = des.ReadClassArray<hkxAttribute>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_name);
            s.WriteClassArray<hkxAttribute>(bw, m_attributes);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteString(xe, nameof(m_name), m_name);
            xs.WriteClassArray<hkxAttribute>(xe, nameof(m_attributes), m_attributes);
        }
    }
}

