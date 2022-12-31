using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpCollidableBoundingVolumeData Signatire: 0xb5f0e6b1 size: 56 flags: FLAGS_NONE

    // m_min m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 3 offset: 0 flags: FLAGS_NONE enum: 
    // m_expansionMin m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 3 offset: 12 flags: FLAGS_NONE enum: 
    // m_expansionShift m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 15 flags: FLAGS_NONE enum: 
    // m_max m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 3 offset: 16 flags: FLAGS_NONE enum: 
    // m_expansionMax m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 3 offset: 28 flags: FLAGS_NONE enum: 
    // m_padding m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 31 flags: FLAGS_NONE enum: 
    // m_numChildShapeAabbs m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 32 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_capacityChildShapeAabbs m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 34 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_childShapeAabbs m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 40 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_childShapeKeys m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 48 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkpCollidableBoundingVolumeData : IHavokObject
    {
        public List<uint> m_min;
        public List<byte> m_expansionMin;
        public byte m_expansionShift;
        public List<uint> m_max;
        public List<byte> m_expansionMax;
        public byte m_padding;
        public ushort m_numChildShapeAabbs;
        public ushort m_capacityChildShapeAabbs;
        public dynamic m_childShapeAabbs;
        public dynamic m_childShapeKeys;

        public virtual uint Signature => 0xb5f0e6b1;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_min = des.ReadUInt32CStyleArray(br, 3);
            m_expansionMin = des.ReadByteCStyleArray(br, 3);
            m_expansionShift = br.ReadByte();
            m_max = des.ReadUInt32CStyleArray(br, 3);
            m_expansionMax = des.ReadByteCStyleArray(br, 3);
            m_padding = br.ReadByte();
            m_numChildShapeAabbs = br.ReadUInt16();
            m_capacityChildShapeAabbs = br.ReadUInt16();
            br.Position += 4;
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteUInt32CStyleArray(bw, m_min);
            s.WriteByteCStyleArray(bw, m_expansionMin);
            bw.WriteByte(m_expansionShift);
            s.WriteUInt32CStyleArray(bw, m_max);
            s.WriteByteCStyleArray(bw, m_expansionMax);
            bw.WriteByte(m_padding);
            bw.WriteUInt16(m_numChildShapeAabbs);
            bw.WriteUInt16(m_capacityChildShapeAabbs);
            bw.Position += 4;
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumberArray(xe, nameof(m_min), m_min);
            xs.WriteNumberArray(xe, nameof(m_expansionMin), m_expansionMin);
            xs.WriteNumber(xe, nameof(m_expansionShift), m_expansionShift);
            xs.WriteNumberArray(xe, nameof(m_max), m_max);
            xs.WriteNumberArray(xe, nameof(m_expansionMax), m_expansionMax);
            xs.WriteNumber(xe, nameof(m_padding), m_padding);
            xs.WriteSerializeIgnored(xe, nameof(m_numChildShapeAabbs));
            xs.WriteSerializeIgnored(xe, nameof(m_capacityChildShapeAabbs));
            xs.WriteSerializeIgnored(xe, nameof(m_childShapeAabbs));
            xs.WriteSerializeIgnored(xe, nameof(m_childShapeKeys));
        }
    }
}

