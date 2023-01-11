using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbEventRangeData Signatire: 0x6cb92c76 size: 32 flags: FLAGS_NONE

    // m_upperBound m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_event m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_eventMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 24 flags: FLAGS_NONE enum: EventRangeMode
    public partial class hkbEventRangeData : IHavokObject
    {
        public float m_upperBound { set; get; } = default;
        public hkbEventProperty m_event { set; get; } = new();
        public sbyte m_eventMode { set; get; } = default;

        public virtual uint Signature => 0x6cb92c76;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_upperBound = br.ReadSingle();
            br.Position += 4;
            m_event.Read(des, br);
            m_eventMode = br.ReadSByte();
            br.Position += 7;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_upperBound);
            bw.Position += 4;
            m_event.Write(s, bw);
            bw.WriteSByte(m_eventMode);
            bw.Position += 7;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_upperBound = xd.ReadSingle(xe, nameof(m_upperBound));
            m_event = xd.ReadClass<hkbEventProperty>(xe, nameof(m_event));
            m_eventMode = xd.ReadFlag<EventRangeMode, sbyte>(xe, nameof(m_eventMode));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteFloat(xe, nameof(m_upperBound), m_upperBound);
            xs.WriteClass<hkbEventProperty>(xe, nameof(m_event), m_event);
            xs.WriteEnum<EventRangeMode, sbyte>(xe, nameof(m_eventMode), m_eventMode);
        }
    }
}

