using System.Xml.Linq;

namespace HKX2
{
    // hkbEventInfo Signatire: 0x5874eed4 size: 4 flags: FLAGS_NONE

    // m_flags m_class:  Type.TYPE_FLAGS Type.TYPE_UINT32 arrSize: 0 offset: 0 flags: FLAGS_NONE enum: Flags
    public partial class hkbEventInfo : IHavokObject
    {
        public uint m_flags;

        public virtual uint Signature => 0x5874eed4;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_flags = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_flags);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteFlag<Flags, uint>(xe, nameof(m_flags), m_flags);
        }
    }
}

