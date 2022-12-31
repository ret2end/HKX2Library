using System.Xml.Linq;

namespace HKX2
{
    // hkbNamedStringEventPayload Signatire: 0x6caa9113 size: 32 flags: FLAGS_NONE

    // m_data m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    public partial class hkbNamedStringEventPayload : hkbNamedEventPayload
    {
        public string m_data;

        public override uint Signature => 0x6caa9113;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_data = des.ReadStringPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_data);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteString(xe, nameof(m_data), m_data);
        }
    }
}

