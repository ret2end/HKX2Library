using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbMoveCharacterModifier Signatire: 0x8f7492a0 size: 112 flags: FLAGS_NONE

    // m_offsetPerSecondMS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_timeSinceLastModify m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbMoveCharacterModifier : hkbModifier
    {

        public Vector4 m_offsetPerSecondMS;
        public float m_timeSinceLastModify;

        public override uint Signature => 0x8f7492a0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_offsetPerSecondMS = br.ReadVector4();
            m_timeSinceLastModify = br.ReadSingle();
            br.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_offsetPerSecondMS);
            bw.WriteSingle(m_timeSinceLastModify);
            bw.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

