using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbDelayedModifier Signatire: 0x8e101a7a size: 104 flags: FLAGS_NONE

    // m_delaySeconds m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_durationSeconds m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 92 flags:  enum: 
    // m_secondsElapsed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_isActive m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 100 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbDelayedModifier : hkbModifierWrapper
    {

        public float m_delaySeconds;
        public float m_durationSeconds;
        public float m_secondsElapsed;
        public bool m_isActive;

        public override uint Signature => 0x8e101a7a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_delaySeconds = br.ReadSingle();
            m_durationSeconds = br.ReadSingle();
            m_secondsElapsed = br.ReadSingle();
            m_isActive = br.ReadBoolean();
            br.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_delaySeconds);
            bw.WriteSingle(m_durationSeconds);
            bw.WriteSingle(m_secondsElapsed);
            bw.WriteBoolean(m_isActive);
            bw.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

