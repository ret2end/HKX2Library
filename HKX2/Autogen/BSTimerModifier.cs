using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSTimerModifier Signatire: 0x531f3292 size: 112 flags: FLAGS_NONE

    // m_alarmTimeSeconds m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_alarmEvent m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_resetAlarm m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 104 flags:  enum: 
    // m_secondsElapsed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 108 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class BSTimerModifier : hkbModifier
    {

        public float m_alarmTimeSeconds;
        public hkbEventProperty/*struct void*/ m_alarmEvent;
        public bool m_resetAlarm;
        public float m_secondsElapsed;

        public override uint Signature => 0x531f3292;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_alarmTimeSeconds = br.ReadSingle();
            br.Position += 4;
            m_alarmEvent = new hkbEventProperty();
            m_alarmEvent.Read(des,br);
            m_resetAlarm = br.ReadBoolean();
            br.Position += 3;
            m_secondsElapsed = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_alarmTimeSeconds);
            bw.Position += 4;
            m_alarmEvent.Write(s, bw);
            bw.WriteBoolean(m_resetAlarm);
            bw.Position += 3;
            bw.WriteSingle(m_secondsElapsed);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

