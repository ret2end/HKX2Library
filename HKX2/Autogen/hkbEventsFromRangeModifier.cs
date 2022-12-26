using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbEventsFromRangeModifier Signatire: 0xbc561b6e size: 112 flags: FLAGS_NONE

    // m_inputValue m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_lowerBound m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags:  enum: 
    // m_eventRanges m_class: hkbEventRangeDataArray Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 88 flags:  enum: 
    // m_wasActiveInPreviousFrame m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 96 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbEventsFromRangeModifier : hkbModifier
    {

        public float m_inputValue;
        public float m_lowerBound;
        public hkbEventRangeDataArray /*pointer struct*/ m_eventRanges;
        public List<ulong> m_wasActiveInPreviousFrame;

        public override uint Signature => 0xbc561b6e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_inputValue = br.ReadSingle();
            m_lowerBound = br.ReadSingle();
            m_eventRanges = des.ReadClassPointer<hkbEventRangeDataArray>(br);
            des.ReadEmptyArray(br); //m_wasActiveInPreviousFrame

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_inputValue);
            bw.WriteSingle(m_lowerBound);
            s.WriteClassPointer(bw, m_eventRanges);
            s.WriteVoidArray(bw); // m_wasActiveInPreviousFrame

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

