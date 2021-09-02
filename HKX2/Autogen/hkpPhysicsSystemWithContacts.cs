using System.Collections.Generic;

namespace HKX2
{
    public class hkpPhysicsSystemWithContacts : hkpPhysicsSystem
    {
        public List<hkpSerializedAgentNnEntry> m_contacts;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_contacts = des.ReadClassPointerArray<hkpSerializedAgentNnEntry>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_contacts);
        }
    }
}