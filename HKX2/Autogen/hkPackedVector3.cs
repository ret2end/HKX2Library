using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkPackedVector3 Signatire: 0x9c16df5b size: 8 flags: FLAGS_NONE

    // m_values m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 4 offset: 0 flags: FLAGS_NONE enum: 
    public partial class hkPackedVector3 : IHavokObject
    {
        public List<short> m_values;

        public virtual uint Signature => 0x9c16df5b;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_values = des.ReadInt16CStyleArray(br, 4);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteInt16CStyleArray(bw, m_values);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumberArray(xe, nameof(m_values), m_values);
        }
    }
}

