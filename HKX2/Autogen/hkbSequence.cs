using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbSequence Signatire: 0x43182ca3 size: 248 flags: FLAGS_NONE

    // m_eventSequencedData m_class: hkbEventSequencedData Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_realVariableSequencedData m_class: hkbRealVariableSequencedData Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_boolVariableSequencedData m_class: hkbBoolVariableSequencedData Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_intVariableSequencedData m_class: hkbIntVariableSequencedData Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    // m_enableEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 144 flags: FLAGS_NONE enum: 
    // m_disableEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 148 flags: FLAGS_NONE enum: 
    // m_stringData m_class: hkbSequenceStringData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 152 flags: FLAGS_NONE enum: 
    // m_variableIdMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 160 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_eventIdMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 168 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_nextSampleEvents m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 176 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_nextSampleReals m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 192 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_nextSampleBools m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 208 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_nextSampleInts m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 224 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 240 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_isEnabled m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 244 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbSequence : hkbModifier
    {
        public List<hkbEventSequencedData> m_eventSequencedData;
        public List<hkbRealVariableSequencedData> m_realVariableSequencedData;
        public List<hkbBoolVariableSequencedData> m_boolVariableSequencedData;
        public List<hkbIntVariableSequencedData> m_intVariableSequencedData;
        public int m_enableEventId;
        public int m_disableEventId;
        public hkbSequenceStringData m_stringData;
        public dynamic m_variableIdMap;
        public dynamic m_eventIdMap;
        public List<dynamic> m_nextSampleEvents;
        public List<dynamic> m_nextSampleReals;
        public List<dynamic> m_nextSampleBools;
        public List<dynamic> m_nextSampleInts;
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
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyArray(br);
            des.ReadEmptyArray(br);
            des.ReadEmptyArray(br);
            des.ReadEmptyArray(br);
            m_time = br.ReadSingle();
            m_isEnabled = br.ReadBoolean();
            br.Position += 3;
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
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidArray(bw);
            s.WriteVoidArray(bw);
            s.WriteVoidArray(bw);
            s.WriteVoidArray(bw);
            bw.WriteSingle(m_time);
            bw.WriteBoolean(m_isEnabled);
            bw.Position += 3;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray<hkbEventSequencedData>(xe, nameof(m_eventSequencedData), m_eventSequencedData);
            xs.WriteClassPointerArray<hkbRealVariableSequencedData>(xe, nameof(m_realVariableSequencedData), m_realVariableSequencedData);
            xs.WriteClassPointerArray<hkbBoolVariableSequencedData>(xe, nameof(m_boolVariableSequencedData), m_boolVariableSequencedData);
            xs.WriteClassPointerArray<hkbIntVariableSequencedData>(xe, nameof(m_intVariableSequencedData), m_intVariableSequencedData);
            xs.WriteNumber(xe, nameof(m_enableEventId), m_enableEventId);
            xs.WriteNumber(xe, nameof(m_disableEventId), m_disableEventId);
            xs.WriteClassPointer(xe, nameof(m_stringData), m_stringData);
            xs.WriteSerializeIgnored(xe, nameof(m_variableIdMap));
            xs.WriteSerializeIgnored(xe, nameof(m_eventIdMap));
            xs.WriteSerializeIgnored(xe, nameof(m_nextSampleEvents));
            xs.WriteSerializeIgnored(xe, nameof(m_nextSampleReals));
            xs.WriteSerializeIgnored(xe, nameof(m_nextSampleBools));
            xs.WriteSerializeIgnored(xe, nameof(m_nextSampleInts));
            xs.WriteSerializeIgnored(xe, nameof(m_time));
            xs.WriteSerializeIgnored(xe, nameof(m_isEnabled));
        }
    }
}

