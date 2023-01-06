using System.Xml.Linq;

namespace HKX2
{
    // hkbVariableValue Signatire: 0xb99bd6a size: 4 flags: FLAGS_NONE

    // m_value m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    public partial class hkbVariableValue : IHavokObject
    {
        public int m_value;

        public virtual uint Signature => 0xb99bd6a;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_value = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_value);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_value = xd.ReadInt32(xe, nameof(m_value));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumber(xe, nameof(m_value), m_value);
        }
    }
}

