using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbStateMachineEventPropertyArray Signatire: 0xb07b4388 size: 32 flags: FLAGS_NONE

    // m_events m_class: hkbEventProperty Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkbStateMachineEventPropertyArray : hkReferencedObject
    {
        public IList<hkbEventProperty> m_events { set; get; } = new List<hkbEventProperty>();

        public override uint Signature => 0xb07b4388;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_events = des.ReadClassArray<hkbEventProperty>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_events);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_events = xd.ReadClassArray<hkbEventProperty>(xe, nameof(m_events));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkbEventProperty>(xe, nameof(m_events), m_events);
        }
    }
}

