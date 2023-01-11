using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkReflectedFileAttribute Signatire: 0xedb6b8f7 size: 8 flags: FLAGS_NONE

    // m_value m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    public partial class hkReflectedFileAttribute : IHavokObject
    {
        public string m_value { set; get; } = "";

        public virtual uint Signature => 0xedb6b8f7;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_value = des.ReadStringPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteCStringPointer(bw, m_value);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_value = xd.ReadString(xe, nameof(m_value));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteString(xe, nameof(m_value), m_value);
        }
    }
}

