using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpEntitySpuCollisionCallback Signatire: 0x81147f05 size: 16 flags: FLAGS_NONE

    // m_util m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 0 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_capacity m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 8 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_eventFilter m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 10 flags: FLAGS_NONE enum: 
    // m_userFilter m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 11 flags: FLAGS_NONE enum: 
    public partial class hkpEntitySpuCollisionCallback : IHavokObject
    {
        private object? m_util { set; get; } = default;
        private ushort m_capacity { set; get; } = default;
        public byte m_eventFilter { set; get; } = default;
        public byte m_userFilter { set; get; } = default;

        public virtual uint Signature => 0x81147f05;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            des.ReadEmptyPointer(br);
            m_capacity = br.ReadUInt16();
            m_eventFilter = br.ReadByte();
            m_userFilter = br.ReadByte();
            br.Position += 4;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVoidPointer(bw);
            bw.WriteUInt16(m_capacity);
            bw.WriteByte(m_eventFilter);
            bw.WriteByte(m_userFilter);
            bw.Position += 4;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_eventFilter = xd.ReadByte(xe, nameof(m_eventFilter));
            m_userFilter = xd.ReadByte(xe, nameof(m_userFilter));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteSerializeIgnored(xe, nameof(m_util));
            xs.WriteSerializeIgnored(xe, nameof(m_capacity));
            xs.WriteNumber(xe, nameof(m_eventFilter), m_eventFilter);
            xs.WriteNumber(xe, nameof(m_userFilter), m_userFilter);
        }
    }
}

