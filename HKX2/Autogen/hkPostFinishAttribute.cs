using System.Xml.Linq;

namespace HKX2
{
    // hkPostFinishAttribute Signatire: 0x903abb2c size: 8 flags: FLAGS_NONE

    // m_postFinishFunction m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 0 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkPostFinishAttribute : IHavokObject
    {
        public dynamic m_postFinishFunction;

        public virtual uint Signature => 0x903abb2c;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            des.ReadEmptyPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVoidPointer(bw);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_postFinishFunction = default;
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteSerializeIgnored(xe, nameof(m_postFinishFunction));
        }
    }
}

