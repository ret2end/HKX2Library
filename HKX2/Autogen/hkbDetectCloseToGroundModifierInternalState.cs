using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbDetectCloseToGroundModifierInternalState Signatire: 0x7b32d942 size: 24 flags: FLAGS_NONE

    // m_isCloseToGround m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbDetectCloseToGroundModifierInternalState : hkReferencedObject
    {

        public bool m_isCloseToGround;

        public override uint Signature => 0x7b32d942;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_isCloseToGround = br.ReadBoolean();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteBoolean(m_isCloseToGround);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

