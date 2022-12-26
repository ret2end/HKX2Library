using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbSequence Signatire: 0x43182ca3 size: 248 flags: FLAGS_NONE

    // m_eventSequencedData m_class: hkbEventSequencedData Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 80 flags:  enum: 
    // m_realVariableSequencedData m_class: hkbRealVariableSequencedData Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 96 flags:  enum: 
    // m_boolVariableSequencedData m_class: hkbBoolVariableSequencedData Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 112 flags:  enum: 
    // m_intVariableSequencedData m_class: hkbIntVariableSequencedData Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 128 flags:  enum: 
    // m_enableEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 144 flags:  enum: 
    // m_disableEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 148 flags:  enum: 
    // m_stringData m_class: hkbSequenceStringData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 152 flags:  enum: 
    // m_variableIdMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 160 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_eventIdMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 168 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_nextSampleEvents m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 176 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_nextSampleReals m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 192 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_nextSampleBools m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 208 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_nextSampleInts m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 224 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 240 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_isEnabled m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 244 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbSequence : hkbModifier
    {

        public List<hkbEventSequencedData> m_eventSequencedData;
        public List<hkbRealVariableSequencedData> m_realVariableSequencedData;
        public List<hkbBoolVariableSequencedData> m_boolVariableSequencedData;
        public List<hkbIntVariableSequencedData> m_intVariableSequencedData;
        public int m_enableEventId;
        public int m_disableEventId;
        public hkbSequenceStringData /*pointer struct*/ m_stringData;
        public dynamic /* POINTER VOID */ m_variableIdMap;
        public dynamic /* POINTER VOID */ m_eventIdMap;
        public List<ulong> m_nextSampleEvents;
        public List<ulong> m_nextSampleReals;
        public List<ulong> m_nextSampleBools;
        public List<ulong> m_nextSampleInts;
        public float m_time;
        public bool m_isEnabled;

        public override uint Signature => 0x43182ca3;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_eventSequencedData = des.ReadClassPointerArray<hkbEventSequencedData>(br);
            m_realVariableSequencedData = des.ReadClassPointerArray<hkbRealVariableSequencedData>(br);
            m_boolVariableSequencedData = des.ReadClassPointerArray<hkbBoolVariableSequencedData>(br);
            m_intVariableSequencedData = des.ReadClassPointerArray<hkbIntVariableSequencedData>(br);
            m_enableEventId = br.ReadInt32();
            m_disableEventId = br.ReadInt32();
            m_stringData = des.ReadClassPointer<hkbSequenceStringData>(br);
            des.ReadEmptyPointer(br);/* m_variableIdMap POINTER VOID */
            des.ReadEmptyPointer(br);/* m_eventIdMap POINTER VOID */
            des.ReadEmptyArray(br); //m_nextSampleEvents
            des.ReadEmptyArray(br); //m_nextSampleReals
            des.ReadEmptyArray(br); //m_nextSampleBools
            des.ReadEmptyArray(br); //m_nextSampleInts
            m_time = br.ReadSingle();
            m_isEnabled = br.ReadBoolean();
            br.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkbEventSequencedData>(bw, m_eventSequencedData);
            s.WriteClassPointerArray<hkbRealVariableSequencedData>(bw, m_realVariableSequencedData);
            s.WriteClassPointerArray<hkbBoolVariableSequencedData>(bw, m_boolVariableSequencedData);
            s.WriteClassPointerArray<hkbIntVariableSequencedData>(bw, m_intVariableSequencedData);
            bw.WriteInt32(m_enableEventId);
            bw.WriteInt32(m_disableEventId);
            s.WriteClassPointer(bw, m_stringData);
            s.WriteVoidPointer(bw);/* m_variableIdMap POINTER VOID */
            s.WriteVoidPointer(bw);/* m_eventIdMap POINTER VOID */
            s.WriteVoidArray(bw); // m_nextSampleEvents
            s.WriteVoidArray(bw); // m_nextSampleReals
            s.WriteVoidArray(bw); // m_nextSampleBools
            s.WriteVoidArray(bw); // m_nextSampleInts
            bw.WriteSingle(m_time);
            bw.WriteBoolean(m_isEnabled);
            bw.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

