using System.Collections.Generic;

namespace HKX2
{
    public class hclBendLinkConstraintSetMx : hclConstraintSet
    {
        public List<hclBendLinkConstraintSetMxBatch> m_batches;
        public List<hclBendLinkConstraintSetMxSingle> m_singles;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_batches = des.ReadClassArray<hclBendLinkConstraintSetMxBatch>(br);
            m_singles = des.ReadClassArray<hclBendLinkConstraintSetMxSingle>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_batches);
            s.WriteClassArray(bw, m_singles);
        }
    }
}