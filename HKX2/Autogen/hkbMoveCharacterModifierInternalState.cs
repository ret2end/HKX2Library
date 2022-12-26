using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbMoveCharacterModifierInternalState Signatire: 0x28f67ba0 size: 24 flags: FLAGS_NONE

    // m_timeSinceLastModify m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbMoveCharacterModifierInternalState : hkReferencedObject
    {

        public float m_timeSinceLastModify;

        public override uint Signature => 0x28f67ba0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_timeSinceLastModify = br.ReadSingle();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_timeSinceLastModify);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

