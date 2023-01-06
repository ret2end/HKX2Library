using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbEventRangeDataArray Signatire: 0x330a56ee size: 32 flags: FLAGS_NONE

    // m_eventData m_class: hkbEventRangeData Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkbEventRangeDataArray : hkReferencedObject
    {
        public List<hkbEventRangeData> m_eventData = new List<hkbEventRangeData>();

        public override uint Signature => 0x330a56ee;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_eventData = des.ReadClassArray<hkbEventRangeData>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray<hkbEventRangeData>(bw, m_eventData);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_eventData = xd.ReadClassArray<hkbEventRangeData>(xe, nameof(m_eventData));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkbEventRangeData>(xe, nameof(m_eventData), m_eventData);
        }
    }
}

