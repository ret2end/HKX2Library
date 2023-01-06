using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbStateMachineTransitionInfoArray Signatire: 0xe397b11e size: 32 flags: FLAGS_NONE

    // m_transitions m_class: hkbStateMachineTransitionInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkbStateMachineTransitionInfoArray : hkReferencedObject
    {
        public List<hkbStateMachineTransitionInfo> m_transitions = new List<hkbStateMachineTransitionInfo>();

        public override uint Signature => 0xe397b11e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_transitions = des.ReadClassArray<hkbStateMachineTransitionInfo>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray<hkbStateMachineTransitionInfo>(bw, m_transitions);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_transitions = xd.ReadClassArray<hkbStateMachineTransitionInfo>(xe, nameof(m_transitions));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkbStateMachineTransitionInfo>(xe, nameof(m_transitions), m_transitions);
        }
    }
}

