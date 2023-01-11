using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbEventBase Signatire: 0x76bddb31 size: 16 flags: FLAGS_NONE

    // m_id m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_payload m_class: hkbEventPayload Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    public partial class hkbEventBase : IHavokObject
    {
        public int m_id { set; get; } = default;
        public hkbEventPayload? m_payload { set; get; } = default;

        public virtual uint Signature => 0x76bddb31;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_id = br.ReadInt32();
            br.Position += 4;
            m_payload = des.ReadClassPointer<hkbEventPayload>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_id);
            bw.Position += 4;
            s.WriteClassPointer(bw, m_payload);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_id = xd.ReadInt32(xe, nameof(m_id));
            m_payload = xd.ReadClassPointer<hkbEventPayload>(xe, nameof(m_payload));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumber(xe, nameof(m_id), m_id);
            xs.WriteClassPointer(xe, nameof(m_payload), m_payload);
        }
    }
}

