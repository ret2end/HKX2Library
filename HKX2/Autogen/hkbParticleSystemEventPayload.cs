using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbParticleSystemEventPayload Signatire: 0x9df46cd6 size: 80 flags: FLAGS_NONE

    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 16 flags:  enum: SystemType
    // m_emitBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 18 flags:  enum: 
    // m_offset m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_direction m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_numParticles m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_speed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 68 flags:  enum: 
    
    public class hkbParticleSystemEventPayload : hkbEventPayload
    {

        public byte m_type;
        public short m_emitBoneIndex;
        public Vector4 m_offset;
        public Vector4 m_direction;
        public int m_numParticles;
        public float m_speed;

        public override uint Signature => 0x9df46cd6;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_type = br.ReadByte();
            br.Position += 1;
            m_emitBoneIndex = br.ReadInt16();
            br.Position += 12;
            m_offset = br.ReadVector4();
            m_direction = br.ReadVector4();
            m_numParticles = br.ReadInt32();
            m_speed = br.ReadSingle();
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteByte(bw, m_type);
            bw.Position += 1;
            bw.WriteInt16(m_emitBoneIndex);
            bw.Position += 12;
            bw.WriteVector4(m_offset);
            bw.WriteVector4(m_direction);
            bw.WriteInt32(m_numParticles);
            bw.WriteSingle(m_speed);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

