using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkCustomAttributes Signatire: 0xbff19005 size: 16 flags: FLAGS_NONE

    // m_attributes m_class: hkCustomAttributesAttribute Type.TYPE_SIMPLEARRAY Type.TYPE_STRUCT arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    public partial class hkCustomAttributes : IHavokObject
    {
        public dynamic m_attributes;

        public virtual uint Signature => 0xbff19005;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            throw new NotImplementedException("TPYE_SIMPLEARRAY");
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            throw new NotImplementedException("TPYE_SIMPLEARRAY");
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            throw new NotImplementedException("TPYE_SIMPLEARRAY");
        }
    }
}

