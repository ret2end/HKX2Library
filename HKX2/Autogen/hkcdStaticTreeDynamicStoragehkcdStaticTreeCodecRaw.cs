using System.Collections.Generic;

namespace HKX2
{
    public class hkcdStaticTreeDynamicStoragehkcdStaticTreeCodecRaw : IHavokObject
    {
        public List<hkcdStaticTreeCodecRaw> m_nodes;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_nodes = des.ReadClassArray<hkcdStaticTreeCodecRaw>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassArray(bw, m_nodes);
        }
    }
}