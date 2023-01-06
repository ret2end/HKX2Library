using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbEventPayloadList Signatire: 0x3d2dbd34 size: 32 flags: FLAGS_NONE

    // m_payloads m_class: hkbEventPayload Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkbEventPayloadList : hkbEventPayload
    {
        public List<hkbEventPayload> m_payloads = new List<hkbEventPayload>();

        public override uint Signature => 0x3d2dbd34;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_payloads = des.ReadClassPointerArray<hkbEventPayload>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray<hkbEventPayload>(bw, m_payloads);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_payloads = xd.ReadClassPointerArray<hkbEventPayload>(xe, nameof(m_payloads));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray<hkbEventPayload>(xe, nameof(m_payloads), m_payloads);
        }
    }
}

