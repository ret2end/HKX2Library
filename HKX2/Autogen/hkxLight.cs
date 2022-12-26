using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxLight Signatire: 0x81c86d42 size: 80 flags: FLAGS_NONE

    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 16 flags:  enum: LightType
    // m_position m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_direction m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_color m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_angle m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 68 flags:  enum: 
    
    public class hkxLight : hkReferencedObject
    {

        public sbyte m_type;
        public Vector4 m_position;
        public Vector4 m_direction;
        public uint m_color;
        public float m_angle;

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

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteSByte(bw, m_type);
            bw.Position += 15;
            bw.WriteVector4(m_position);
            bw.WriteVector4(m_direction);
            bw.WriteUInt32(m_color);
            bw.WriteSingle(m_angle);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

