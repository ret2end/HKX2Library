using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkCustomAttributesAttribute Signatire: 0x1388d601 size: 24 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_value m_class:  Type.TYPE_VARIANT Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    public partial class hkCustomAttributesAttribute : IHavokObject
    {
        public string m_name;
        public string m_value;

        public virtual uint Signature => 0x1388d601;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_name = des.ReadStringPointer(br);
            throw new NotImplementedException("TPYE_VARIANT");
            br.Position += 8;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_name);
            throw new NotImplementedException("TPYE_VARIANT");
            bw.Position += 8;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteString(xe, nameof(m_name), m_name);
            throw new NotImplementedException("TPYE_VARIANT");
        }
    }
}

