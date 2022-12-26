using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbRotateCharacterModifierInternalState Signatire: 0xdc40bf4a size: 24 flags: FLAGS_NONE

    // m_angle m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbRotateCharacterModifierInternalState : hkReferencedObject
    {

        public float m_angle;

        public override uint Signature => 0xdc40bf4a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_angle = br.ReadSingle();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_angle);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

