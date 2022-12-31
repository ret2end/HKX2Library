using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkaMeshBindingMapping Signatire: 0x48aceb75 size: 16 flags: FLAGS_NONE

    // m_mapping m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    public partial class hkaMeshBindingMapping : IHavokObject
    {
        public List<short> m_mapping;

        public virtual uint Signature => 0x48aceb75;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_mapping = des.ReadInt16Array(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteInt16Array(bw, m_mapping);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumberArray(xe, nameof(m_mapping), m_mapping);
        }
    }
}

