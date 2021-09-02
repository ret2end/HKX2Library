using System.Collections.Generic;

namespace HKX2
{
    public class hclStretchLinkConstraintSetMx : hclConstraintSet
    {
        public List<hclStretchLinkConstraintSetMxBatch> m_batches;
        public List<hclStretchLinkConstraintSetMxSingle> m_singles;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_batches = des.ReadClassArray<hclStretchLinkConstraintSetMxBatch>(br);
            m_singles = des.ReadClassArray<hclStretchLinkConstraintSetMxSingle>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_batches);
            s.WriteClassArray(bw, m_singles);
        }
    }
}