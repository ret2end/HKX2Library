using System.Xml.Linq;

namespace HKX2
{
    // hkpMoppCodeReindexedTerminal Signatire: 0x6ed8ac06 size: 8 flags: FLAGS_NONE

    // m_origShapeKey m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_reindexedShapeKey m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    public partial class hkpMoppCodeReindexedTerminal : IHavokObject
    {
        public uint m_origShapeKey;
        public uint m_reindexedShapeKey;

        public virtual uint Signature => 0x6ed8ac06;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_origShapeKey = br.ReadUInt32();
            m_reindexedShapeKey = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_origShapeKey);
            bw.WriteUInt32(m_reindexedShapeKey);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumber(xe, nameof(m_origShapeKey), m_origShapeKey);
            xs.WriteNumber(xe, nameof(m_reindexedShapeKey), m_reindexedShapeKey);
        }
    }
}

