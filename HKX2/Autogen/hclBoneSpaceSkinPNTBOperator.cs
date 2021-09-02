using System.Collections.Generic;

namespace HKX2
{
    public class hclBoneSpaceSkinPNTBOperator : hclBoneSpaceSkinOperator
    {
        public List<hclBoneSpaceDeformerLocalBlockPNTB> m_localPNTBs;
        public List<hclBoneSpaceDeformerLocalBlockUnpackedPNTB> m_localUnpackedPNTBs;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_localPNTBs = des.ReadClassArray<hclBoneSpaceDeformerLocalBlockPNTB>(br);
            m_localUnpackedPNTBs = des.ReadClassArray<hclBoneSpaceDeformerLocalBlockUnpackedPNTB>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_localPNTBs);
            s.WriteClassArray(bw, m_localUnpackedPNTBs);
        }
    }
}