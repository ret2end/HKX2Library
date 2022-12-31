using System.Xml.Linq;

namespace HKX2
{
    // hkxVertexDescriptionElementDecl Signatire: 0x483a429b size: 16 flags: FLAGS_NONE

    // m_byteOffset m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_UINT16 arrSize: 0 offset: 4 flags: FLAGS_NONE enum: DataType
    // m_usage m_class:  Type.TYPE_ENUM Type.TYPE_UINT16 arrSize: 0 offset: 6 flags: FLAGS_NONE enum: DataUsage
    // m_byteStride m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_numElements m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    public partial class hkxVertexDescriptionElementDecl : IHavokObject
    {
        public uint m_byteOffset;
        public ushort m_type;
        public ushort m_usage;
        public uint m_byteStride;
        public byte m_numElements;

        public virtual uint Signature => 0x483a429b;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_byteOffset = br.ReadUInt32();
            m_type = br.ReadUInt16();
            m_usage = br.ReadUInt16();
            m_byteStride = br.ReadUInt32();
            m_numElements = br.ReadByte();
            br.Position += 3;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_byteOffset);
            s.WriteUInt16(bw, m_type);
            s.WriteUInt16(bw, m_usage);
            bw.WriteUInt32(m_byteStride);
            bw.WriteByte(m_numElements);
            bw.Position += 3;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumber(xe, nameof(m_byteOffset), m_byteOffset);
            xs.WriteEnum<DataType, ushort>(xe, nameof(m_type), m_type);
            xs.WriteEnum<DataUsage, ushort>(xe, nameof(m_usage), m_usage);
            xs.WriteNumber(xe, nameof(m_byteStride), m_byteStride);
            xs.WriteNumber(xe, nameof(m_numElements), m_numElements);
        }
    }
}

