using System.Collections.Generic;

namespace HKX2
{
    public class hclCompressibleLinkConstraintSetMx : hclConstraintSet
    {
        public List<hclCompressibleLinkConstraintSetMxBatch> m_batches;
        public List<hclCompressibleLinkConstraintSetMxSingle> m_singles;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_batches = des.ReadClassArray<hclCompressibleLinkConstraintSetMxBatch>(br);
            m_singles = des.ReadClassArray<hclCompressibleLinkConstraintSetMxSingle>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_batches);
            s.WriteClassArray(bw, m_singles);
        }
    }
}