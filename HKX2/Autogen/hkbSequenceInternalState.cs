using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbSequenceInternalState Signatire: 0x419b9a05 size: 88 flags: FLAGS_NONE

    // m_nextSampleEvents m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_nextSampleReals m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_nextSampleBools m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_nextSampleInts m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_isEnabled m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 84 flags: FLAGS_NONE enum: 
    public partial class hkbSequenceInternalState : hkReferencedObject
    {
        public List<int> m_nextSampleEvents;
        public List<int> m_nextSampleReals;
        public List<int> m_nextSampleBools;
        public List<int> m_nextSampleInts;
        public float m_time;
        public bool m_isEnabled;

        public override uint Signature => 0x419b9a05;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_nextSampleEvents = des.ReadInt32Array(br);
            m_nextSampleReals = des.ReadInt32Array(br);
            m_nextSampleBools = des.ReadInt32Array(br);
            m_nextSampleInts = des.ReadInt32Array(br);
            m_time = br.ReadSingle();
            m_isEnabled = br.ReadBoolean();
            br.Position += 3;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteInt32Array(bw, m_nextSampleEvents);
            s.WriteInt32Array(bw, m_nextSampleReals);
            s.WriteInt32Array(bw, m_nextSampleBools);
            s.WriteInt32Array(bw, m_nextSampleInts);
            bw.WriteSingle(m_time);
            bw.WriteBoolean(m_isEnabled);
            bw.Position += 3;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_nextSampleEvents = xd.ReadInt32Array(xe, nameof(m_nextSampleEvents));
            m_nextSampleReals = xd.ReadInt32Array(xe, nameof(m_nextSampleReals));
            m_nextSampleBools = xd.ReadInt32Array(xe, nameof(m_nextSampleBools));
            m_nextSampleInts = xd.ReadInt32Array(xe, nameof(m_nextSampleInts));
            m_time = xd.ReadSingle(xe, nameof(m_time));
            m_isEnabled = xd.ReadBoolean(xe, nameof(m_isEnabled));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumberArray(xe, nameof(m_nextSampleEvents), m_nextSampleEvents);
            xs.WriteNumberArray(xe, nameof(m_nextSampleReals), m_nextSampleReals);
            xs.WriteNumberArray(xe, nameof(m_nextSampleBools), m_nextSampleBools);
            xs.WriteNumberArray(xe, nameof(m_nextSampleInts), m_nextSampleInts);
            xs.WriteFloat(xe, nameof(m_time), m_time);
            xs.WriteBoolean(xe, nameof(m_isEnabled), m_isEnabled);
        }
    }
}

