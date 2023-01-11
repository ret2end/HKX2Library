using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpCdBody Signatire: 0x54a4b841 size: 32 flags: FLAGS_NONE

    // m_shape m_class: hkpShape Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_shapeKey m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_motion m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 16 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_parent m_class: hkpCdBody Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkpCdBody : IHavokObject
    {
        public hkpShape? m_shape { set; get; } = default;
        public uint m_shapeKey { set; get; } = default;
        private object? m_motion { set; get; } = default;
        private hkpCdBody? m_parent { set; get; } = default;

        public virtual uint Signature => 0x54a4b841;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_shape = des.ReadClassPointer<hkpShape>(br);
            m_shapeKey = br.ReadUInt32();
            br.Position += 4;
            des.ReadEmptyPointer(br);
            m_parent = des.ReadClassPointer<hkpCdBody>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_shape);
            bw.WriteUInt32(m_shapeKey);
            bw.Position += 4;
            s.WriteVoidPointer(bw);
            s.WriteClassPointer(bw, m_parent);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_shape = xd.ReadClassPointer<hkpShape>(xe, nameof(m_shape));
            m_shapeKey = xd.ReadUInt32(xe, nameof(m_shapeKey));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClassPointer(xe, nameof(m_shape), m_shape);
            xs.WriteNumber(xe, nameof(m_shapeKey), m_shapeKey);
            xs.WriteSerializeIgnored(xe, nameof(m_motion));
            xs.WriteSerializeIgnored(xe, nameof(m_parent));
        }
    }
}

