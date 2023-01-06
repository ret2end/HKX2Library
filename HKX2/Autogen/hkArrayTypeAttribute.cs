using System.Xml.Linq;

namespace HKX2
{
    // hkArrayTypeAttribute Signatire: 0xd404a39a size: 1 flags: FLAGS_NONE

    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 0 flags: FLAGS_NONE enum: ArrayType
    public partial class hkArrayTypeAttribute : IHavokObject
    {
        public sbyte m_type;

        public virtual uint Signature => 0xd404a39a;

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
            m_type = xd.ReadFlag<ArrayType, sbyte>(xe, nameof(m_type));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteEnum<ArrayType, sbyte>(xe, nameof(m_type), m_type);
        }
    }
}

