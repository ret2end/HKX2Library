using System.Collections.Generic;

namespace HKX2
{
    public class hclStandardLinkConstraintSetMx : hclConstraintSet
    {
        public List<hclStandardLinkConstraintSetMxBatch> m_batches;
        public List<hclStandardLinkConstraintSetMxSingle> m_singles;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_batches = des.ReadClassArray<hclStandardLinkConstraintSetMxBatch>(br);
            m_singles = des.ReadClassArray<hclStandardLinkConstraintSetMxSingle>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_batches);
            s.WriteClassArray(bw, m_singles);
        }
    }
}