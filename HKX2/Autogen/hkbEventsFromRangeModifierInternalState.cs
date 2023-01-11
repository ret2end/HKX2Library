using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbEventsFromRangeModifierInternalState Signatire: 0xcc47b48d size: 32 flags: FLAGS_NONE

    // m_wasActiveInPreviousFrame m_class:  Type.TYPE_ARRAY Type.TYPE_BOOL arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkbEventsFromRangeModifierInternalState : hkReferencedObject
    {
        public IList<bool> m_wasActiveInPreviousFrame { set; get; } = new List<bool>();

        public override uint Signature => 0xcc47b48d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_wasActiveInPreviousFrame = des.ReadBooleanArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteBooleanArray(bw, m_wasActiveInPreviousFrame);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_wasActiveInPreviousFrame = xd.ReadBooleanArray(xe, nameof(m_wasActiveInPreviousFrame));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteBooleanArray(xe, nameof(m_wasActiveInPreviousFrame), m_wasActiveInPreviousFrame);
        }
    }
}

