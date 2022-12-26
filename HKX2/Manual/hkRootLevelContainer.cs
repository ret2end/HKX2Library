using System.Collections.Generic;

namespace HKX2
{
    // hkRootLevelContainer Signatire: 0x2772c11e size: 16 flags: FLAGS_NONE

    // m_namedVariants m_class: hkRootLevelContainerNamedVariant Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 

    public class hkRootLevelContainer : IHavokObject
    {

        public List<hkRootLevelContainerNamedVariant> m_namedVariants;

        public uint Signature => 0x2772c11e;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_namedVariants = des.ReadClassArray<hkRootLevelContainerNamedVariant>(br);

        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteClassArray<hkRootLevelContainerNamedVariant>(bw, m_namedVariants);

        }
    }
}

