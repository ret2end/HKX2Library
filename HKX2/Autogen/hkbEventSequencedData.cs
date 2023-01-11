using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbEventSequencedData Signatire: 0x76798eb8 size: 32 flags: FLAGS_NONE

    // m_events m_class: hkbEventSequencedDataSequencedEvent Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkbEventSequencedData : hkbSequencedData
    {
        public IList<hkbEventSequencedDataSequencedEvent> m_events { set; get; } = new List<hkbEventSequencedDataSequencedEvent>();

        public override uint Signature => 0x76798eb8;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_events = des.ReadClassArray<hkbEventSequencedDataSequencedEvent>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_events);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_events = xd.ReadClassArray<hkbEventSequencedDataSequencedEvent>(xe, nameof(m_events));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkbEventSequencedDataSequencedEvent>(xe, nameof(m_events), m_events);
        }
    }
}

