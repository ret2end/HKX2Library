using System.Collections.Generic;

namespace HKX2
{
    public class hkcdStaticTreeDynamicStoragehkcdStaticTreeCodec3Axis4 : IHavokObject
    {
        public List<hkcdStaticTreeCodec3Axis4> m_nodes;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_nodes = des.ReadClassArray<hkcdStaticTreeCodec3Axis4>(br);
            br.Pad(16);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassArray(bw, m_nodes);
            bw.Pad(16);
        }
    }
}