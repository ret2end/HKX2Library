using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbEventSequencedDataSequencedEvent Signatire: 0x9139b821 size: 32 flags: FLAGS_NONE

    // m_event m_class: hkbEvent Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    public partial class hkbEventSequencedDataSequencedEvent : IHavokObject
    {
        public hkbEvent m_event { set; get; } = new();
        public float m_time { set; get; } = default;

        public virtual uint Signature => 0x9139b821;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_event.Read(des, br);
            m_time = br.ReadSingle();
            br.Position += 4;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_event.Write(s, bw);
            bw.WriteSingle(m_time);
            bw.Position += 4;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_event = xd.ReadClass<hkbEvent>(xe, nameof(m_event));
            m_time = xd.ReadSingle(xe, nameof(m_time));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClass<hkbEvent>(xe, nameof(m_event), m_event);
            xs.WriteFloat(xe, nameof(m_time), m_time);
        }
    }
}

