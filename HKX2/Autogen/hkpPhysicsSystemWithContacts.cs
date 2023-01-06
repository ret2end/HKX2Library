using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpPhysicsSystemWithContacts Signatire: 0xd0fd4bbe size: 120 flags: FLAGS_NONE

    // m_contacts m_class: hkpSerializedAgentNnEntry Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    public partial class hkpPhysicsSystemWithContacts : hkpPhysicsSystem
    {
        public List<hkpSerializedAgentNnEntry> m_contacts = new List<hkpSerializedAgentNnEntry>();

        public override uint Signature => 0xd0fd4bbe;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_contacts = des.ReadClassPointerArray<hkpSerializedAgentNnEntry>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray<hkpSerializedAgentNnEntry>(bw, m_contacts);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_contacts = xd.ReadClassPointerArray<hkpSerializedAgentNnEntry>(xe, nameof(m_contacts));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray<hkpSerializedAgentNnEntry>(xe, nameof(m_contacts), m_contacts);
        }
    }
}

