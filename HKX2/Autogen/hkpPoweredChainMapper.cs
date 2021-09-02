using System.Collections.Generic;

namespace HKX2
{
    public class hkpPoweredChainMapper : hkReferencedObject
    {
        public List<hkpConstraintChainInstance> m_chains;

        public List<hkpPoweredChainMapperLinkInfo> m_links;
        public List<hkpPoweredChainMapperTarget> m_targets;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_links = des.ReadClassArray<hkpPoweredChainMapperLinkInfo>(br);
            m_targets = des.ReadClassArray<hkpPoweredChainMapperTarget>(br);
            m_chains = des.ReadClassPointerArray<hkpConstraintChainInstance>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_links);
            s.WriteClassArray(bw, m_targets);
            s.WriteClassPointerArray(bw, m_chains);
        }
    }
}