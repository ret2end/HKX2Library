using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbEventsFromRangeModifier Signatire: 0xbc561b6e size: 112 flags: FLAGS_NONE

    // m_inputValue m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_lowerBound m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags: FLAGS_NONE enum: 
    // m_eventRanges m_class: hkbEventRangeDataArray Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_wasActiveInPreviousFrame m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 96 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbEventsFromRangeModifier : hkbModifier
    {
        public float m_inputValue;
        public float m_lowerBound;
        public hkbEventRangeDataArray m_eventRanges;
        public List<dynamic> m_wasActiveInPreviousFrame;

        public override uint Signature => 0xbc561b6e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_inputValue = br.ReadSingle();
            m_lowerBound = br.ReadSingle();
            m_eventRanges = des.ReadClassPointer<hkbEventRangeDataArray>(br);
            des.ReadEmptyArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_inputValue);
            bw.WriteSingle(m_lowerBound);
            s.WriteClassPointer(bw, m_eventRanges);
            s.WriteVoidArray(bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteFloat(xe, nameof(m_inputValue), m_inputValue);
            xs.WriteFloat(xe, nameof(m_lowerBound), m_lowerBound);
            xs.WriteClassPointer(xe, nameof(m_eventRanges), m_eventRanges);
            xs.WriteSerializeIgnored(xe, nameof(m_wasActiveInPreviousFrame));
        }
    }
}

