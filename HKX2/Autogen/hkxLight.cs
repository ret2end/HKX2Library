using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkxLight Signatire: 0x81c86d42 size: 80 flags: FLAGS_NONE

    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 16 flags: FLAGS_NONE enum: LightType
    // m_position m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_direction m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_color m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_angle m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 68 flags: FLAGS_NONE enum: 
    public partial class hkxLight : hkReferencedObject
    {
        public sbyte m_type { set; get; } = default;
        public Vector4 m_position { set; get; } = default;
        public Vector4 m_direction { set; get; } = default;
        public uint m_color { set; get; } = default;
        public float m_angle { set; get; } = default;

        public override uint Signature => 0x81c86d42;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_type = br.ReadSByte();
            br.Position += 15;
            m_position = br.ReadVector4();
            m_direction = br.ReadVector4();
            m_color = br.ReadUInt32();
            m_angle = br.ReadSingle();
            br.Position += 8;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSByte(m_type);
            bw.Position += 15;
            bw.WriteVector4(m_position);
            bw.WriteVector4(m_direction);
            bw.WriteUInt32(m_color);
            bw.WriteSingle(m_angle);
            bw.Position += 8;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_type = xd.ReadFlag<LightType, sbyte>(xe, nameof(m_type));
            m_position = xd.ReadVector4(xe, nameof(m_position));
            m_direction = xd.ReadVector4(xe, nameof(m_direction));
            m_color = xd.ReadUInt32(xe, nameof(m_color));
            m_angle = xd.ReadSingle(xe, nameof(m_angle));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteEnum<LightType, sbyte>(xe, nameof(m_type), m_type);
            xs.WriteVector4(xe, nameof(m_position), m_position);
            xs.WriteVector4(xe, nameof(m_direction), m_direction);
            xs.WriteNumber(xe, nameof(m_color), m_color);
            xs.WriteFloat(xe, nameof(m_angle), m_angle);
        }
    }
}

