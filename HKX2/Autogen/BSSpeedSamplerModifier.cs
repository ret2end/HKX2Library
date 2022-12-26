using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSSpeedSamplerModifier Signatire: 0xd297fda9 size: 96 flags: FLAGS_NONE

    // m_state m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_direction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags:  enum: 
    // m_goalSpeed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_speedOut m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 92 flags:  enum: 
    
    public class BSSpeedSamplerModifier : hkbModifier
    {

        public int m_state;
        public float m_direction;
        public float m_goalSpeed;
        public float m_speedOut;

        public override uint Signature => 0xd297fda9;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_state = br.ReadInt32();
            m_direction = br.ReadSingle();
            m_goalSpeed = br.ReadSingle();
            m_speedOut = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteInt32(m_state);
            bw.WriteSingle(m_direction);
            bw.WriteSingle(m_goalSpeed);
            bw.WriteSingle(m_speedOut);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

