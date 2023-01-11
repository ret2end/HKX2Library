using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkRootLevelContainerNamedVariant Signatire: 0xb103a2cd size: 24 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_className m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_variant m_class: hkReferencedObject Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 

    public partial class hkRootLevelContainerNamedVariant : IHavokObject
    {

        public string m_name { set; get; } = "";
        public string m_className { set; get; } = "";
        public hkReferencedObject? m_variant { set; get; } = default;

        public uint Signature => 0xb103a2cd;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_name = des.ReadStringPointer(br);
            m_className = des.ReadStringPointer(br);
            m_variant = des.ReadClassPointer<hkReferencedObject>(br);

        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_name);
            s.WriteStringPointer(bw, m_className);
            s.WriteClassPointer(bw, m_variant);

        }

        public void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_name = xd.ReadString(xe, nameof(m_name));
            m_className = xd.ReadString(xe, nameof(m_className));
            m_variant = xd.ReadClassPointer<hkReferencedObject>(xe, nameof(m_variant));
        }

        public void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteString(xe, nameof(m_name), m_name);
            xs.WriteString(xe, nameof(m_className), m_className);
            xs.WriteClassPointer(xe, nameof(m_variant), m_variant);
        }
    }
}

