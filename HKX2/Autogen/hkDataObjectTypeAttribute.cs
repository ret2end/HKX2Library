using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkDataObjectTypeAttribute Signatire: 0x1e3857bb size: 8 flags: FLAGS_NONE

    // m_typeName m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    public partial class hkDataObjectTypeAttribute : IHavokObject
    {
        public string m_typeName { set; get; } = "";

        public virtual uint Signature => 0x1e3857bb;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_typeName = des.ReadStringPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteCStringPointer(bw, m_typeName);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_typeName = xd.ReadString(xe, nameof(m_typeName));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteString(xe, nameof(m_typeName), m_typeName);
        }
    }
}

