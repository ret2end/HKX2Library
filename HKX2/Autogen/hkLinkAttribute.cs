using System.Xml.Linq;

namespace HKX2
{
    // hkLinkAttribute Signatire: 0x255d8164 size: 1 flags: FLAGS_NONE

    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 0 flags: FLAGS_NONE enum: Link
    public partial class hkLinkAttribute : IHavokObject
    {
        public sbyte m_type;

        public virtual uint Signature => 0x255d8164;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_type = br.ReadSByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteSByte(bw, m_type);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_type = xd.ReadFlag<Link, sbyte>(xe, nameof(m_type));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteEnum<Link, sbyte>(xe, nameof(m_type), m_type);
        }
    }
}

