using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbTimerModifier Signatire: 0x338b4879 size: 112 flags: FLAGS_NONE

    // m_alarmTimeSeconds m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_alarmEvent m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_secondsElapsed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 104 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbTimerModifier : hkbModifier
    {

        public float m_alarmTimeSeconds;
        public hkbEventProperty/*struct void*/ m_alarmEvent;
        public float m_secondsElapsed;

        public override uint Signature => 0x338b4879;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_alarmTimeSeconds = br.ReadSingle();
            br.Position += 4;
            m_alarmEvent = new hkbEventProperty();
            m_alarmEvent.Read(des,br);
            m_secondsElapsed = br.ReadSingle();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_alarmTimeSeconds);
            bw.Position += 4;
            m_alarmEvent.Write(s, bw);
            bw.WriteSingle(m_secondsElapsed);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

