using System.Xml.Linq;

namespace HKX2
{
    // hkpPropertyValue Signatire: 0xc75925aa size: 8 flags: FLAGS_NONE

    // m_data m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    public partial class hkpPropertyValue : IHavokObject
    {
        public ulong m_data;

        public virtual uint Signature => 0xc75925aa;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_data = br.ReadUInt64();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt64(m_data);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumber(xe, nameof(m_data), m_data);
        }
    }
}

