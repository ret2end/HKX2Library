using System.Xml.Linq;

namespace HKX2
{
    // hkpConstraintAtom Signatire: 0x59d67ef6 size: 2 flags: FLAGS_NONE

    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_UINT16 arrSize: 0 offset: 0 flags: FLAGS_NONE enum: AtomType
    public partial class hkpConstraintAtom : IHavokObject
    {
        public ushort m_type;

        public virtual uint Signature => 0x59d67ef6;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_type = br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteUInt16(bw, m_type);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_type = xd.ReadFlag<AtomType, ushort>(xe, nameof(m_type));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteEnum<AtomType, ushort>(xe, nameof(m_type), m_type);
        }
    }
}

