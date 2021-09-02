using System.Collections.Generic;

namespace HKX2
{
    public class hclObjectSpaceSkinPNTBOperator : hclObjectSpaceSkinOperator
    {
        public List<hclObjectSpaceDeformerLocalBlockPNTB> m_localPNTBs;
        public List<hclObjectSpaceDeformerLocalBlockUnpackedPNTB> m_localUnpackedPNTBs;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_localPNTBs = des.ReadClassArray<hclObjectSpaceDeformerLocalBlockPNTB>(br);
            m_localUnpackedPNTBs = des.ReadClassArray<hclObjectSpaceDeformerLocalBlockUnpackedPNTB>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_localPNTBs);
            s.WriteClassArray(bw, m_localUnpackedPNTBs);
        }
    }
}