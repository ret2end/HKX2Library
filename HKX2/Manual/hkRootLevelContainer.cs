using System.Collections.Generic;

namespace HKX2
{
    public class hkRootLevelContainer : IHavokObject
    {
        public List<hkRootLevelContainerNamedVariant> m_namedVariants;
        public virtual uint Signature => 0x2772C11E;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_namedVariants = des.ReadClassArray<hkRootLevelContainerNamedVariant>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassArray(bw, m_namedVariants);
        }
    }
}