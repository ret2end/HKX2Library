using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpLinkedCollidable Signatire: 0xe1a81497 size: 128 flags: FLAGS_NONE

    // m_collisionEntries m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 112 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkpLinkedCollidable : hkpCollidable
    {
        public List<dynamic> m_collisionEntries;

        public override uint Signature => 0xe1a81497;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            des.ReadEmptyArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVoidArray(bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_collisionEntries = default;
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteSerializeIgnored(xe, nameof(m_collisionEntries));
        }
    }
}

