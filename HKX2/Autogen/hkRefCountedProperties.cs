using System.Collections.Generic;

namespace HKX2
{
    public enum ReferenceCountHandling
    {
        REFERENCE_COUNT_INCREMENT = 0,
        REFERENCE_COUNT_IGNORE = 1
    }

    public class hkRefCountedProperties : IHavokObject
    {
        public List<hkRefCountedPropertiesEntry> m_entries;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_entries = des.ReadClassArray<hkRefCountedPropertiesEntry>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassArray(bw, m_entries);
        }
    }
}