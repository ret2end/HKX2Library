using System.Collections.Generic;

namespace HKX2
{
    public class
        hkcdDynamicTreeDynamicStorage0hkcdDynamicTreeAnisotropicMetrichkcdDynamicTreeCodecRawUint :
            hkcdDynamicTreeAnisotropicMetric
    {
        public uint m_firstFree;

        public List<hkcdDynamicTreeCodecRawUint> m_nodes;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_nodes = des.ReadClassArray<hkcdDynamicTreeCodecRawUint>(br);
            m_firstFree = br.ReadUInt32();
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_nodes);
            bw.WriteUInt32(m_firstFree);
            bw.WriteUInt32(0);
        }
    }
}