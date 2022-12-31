using System.Xml.Linq;

namespace HKX2
{
    // hkxMaterialProperty Signatire: 0xd295234d size: 8 flags: FLAGS_NONE

    // m_key m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_value m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    public partial class hkxMaterialProperty : IHavokObject
    {
        public uint m_key;
        public uint m_value;

        public virtual uint Signature => 0xd295234d;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_key = br.ReadUInt32();
            m_value = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_key);
            bw.WriteUInt32(m_value);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumber(xe, nameof(m_key), m_key);
            xs.WriteNumber(xe, nameof(m_value), m_value);
        }
    }
}

