using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbTimerModifierInternalState Signatire: 0x83ec2d42 size: 24 flags: FLAGS_NONE

    // m_secondsElapsed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbTimerModifierInternalState : hkReferencedObject
    {

        public float m_secondsElapsed;

        public override uint Signature => 0x83ec2d42;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_secondsElapsed = br.ReadSingle();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_secondsElapsed);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

