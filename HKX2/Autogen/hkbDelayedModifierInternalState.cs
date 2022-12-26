using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbDelayedModifierInternalState Signatire: 0x85fb0b80 size: 24 flags: FLAGS_NONE

    // m_secondsElapsed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_isActive m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 20 flags:  enum: 
    
    public class hkbDelayedModifierInternalState : hkReferencedObject
    {

        public float m_secondsElapsed;
        public bool m_isActive;

        public override uint Signature => 0x85fb0b80;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_secondsElapsed = br.ReadSingle();
            m_isActive = br.ReadBoolean();
            br.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_secondsElapsed);
            bw.WriteBoolean(m_isActive);
            bw.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}
