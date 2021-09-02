using System.Collections.Generic;

namespace HKX2
{
    public class hkcdStaticTreeDynamicStoragehkcdStaticTreeCodec3Axis5 : IHavokObject
    {
        public List<hkcdStaticTreeCodec3Axis5> m_nodes;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_nodes = des.ReadClassArray<hkcdStaticTreeCodec3Axis5>(br);
            br.Pad(16);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassArray(bw, m_nodes);
            bw.Pad(16);
        }
    }
}