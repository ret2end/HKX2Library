using System.Collections.Generic;

namespace HKX2
{
    public class
        hkcdDynamicTreeDynamicStorage0hkcdDynamicTreeAnisotropicMetrichkcdDynamicTreeCodecRawUlong :
            hkcdDynamicTreeAnisotropicMetric
    {
        public ulong m_firstFree;

        public List<hkcdDynamicTreeCodecRawUlong> m_nodes;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_nodes = des.ReadClassArray<hkcdDynamicTreeCodecRawUlong>(br);
            m_firstFree = br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_nodes);
            bw.WriteUInt64(m_firstFree);
        }
    }
}