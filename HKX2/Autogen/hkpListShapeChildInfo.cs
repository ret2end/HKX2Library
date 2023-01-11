using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpListShapeChildInfo Signatire: 0x80df0f90 size: 32 flags: FLAGS_NONE

    // m_shape m_class: hkpShape Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 0 flags: ALIGN_16|FLAGS_NONE enum: 
    // m_collisionFilterInfo m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_shapeSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_numChildShapes m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 16 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkpListShapeChildInfo : IHavokObject
    {
        public hkpShape? m_shape { set; get; } = default;
        public uint m_collisionFilterInfo { set; get; } = default;
        private int m_shapeSize { set; get; } = default;
        private int m_numChildShapes { set; get; } = default;

        public virtual uint Signature => 0x80df0f90;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_shape = des.ReadClassPointer<hkpShape>(br);
            m_collisionFilterInfo = br.ReadUInt32();
            m_shapeSize = br.ReadInt32();
            m_numChildShapes = br.ReadInt32();
            br.Position += 12;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_shape);
            bw.WriteUInt32(m_collisionFilterInfo);
            bw.WriteInt32(m_shapeSize);
            bw.WriteInt32(m_numChildShapes);
            bw.Position += 12;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_shape = xd.ReadClassPointer<hkpShape>(xe, nameof(m_shape));
            m_collisionFilterInfo = xd.ReadUInt32(xe, nameof(m_collisionFilterInfo));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClassPointer(xe, nameof(m_shape), m_shape);
            xs.WriteNumber(xe, nameof(m_collisionFilterInfo), m_collisionFilterInfo);
            xs.WriteSerializeIgnored(xe, nameof(m_shapeSize));
            xs.WriteSerializeIgnored(xe, nameof(m_numChildShapes));
        }
    }
}

