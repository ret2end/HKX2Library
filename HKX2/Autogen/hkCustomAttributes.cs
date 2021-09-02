using System.Collections.Generic;

namespace HKX2
{
    public class hkCustomAttributes : IHavokObject
    {
        public List<hkCustomAttributesAttribute> m_attributes;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            // Read TYPE_SIMPLEARRAY
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            // Read TYPE_SIMPLEARRAY
        }
    }
}