using System.Collections.Generic;

namespace HKX2
{
    public class hclCompressibleLinkConstraintSet : hclConstraintSet
    {
        public List<hclCompressibleLinkConstraintSetLink> m_links;
        public override uint Signature => 0x51E7D475;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_links = des.ReadClassArray<hclCompressibleLinkConstraintSetLink>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_links);
        }
    }
}