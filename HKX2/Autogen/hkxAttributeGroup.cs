using System.Collections.Generic;

namespace HKX2
{
    public class hkxAttributeGroup : IHavokObject
    {
        public List<hkxAttribute> m_attributes;

        public string m_name;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_name = des.ReadStringPointer(br);
            m_attributes = des.ReadClassArray<hkxAttribute>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_name);
            s.WriteClassArray(bw, m_attributes);
        }
    }
}