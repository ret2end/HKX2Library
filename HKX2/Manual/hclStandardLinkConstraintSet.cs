using System.Collections.Generic;

namespace HKX2
{
    public class hclStandardLinkConstraintSet : hclConstraintSet
    {
        public List<hclStandardLinkConstraintSetLink> m_links;
        public override uint Signature => 0x426B3354;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_links = des.ReadClassArray<hclStandardLinkConstraintSetLink>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_links);
        }
    }
}