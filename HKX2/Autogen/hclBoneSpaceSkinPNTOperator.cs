using System.Collections.Generic;

namespace HKX2
{
    public class hclBoneSpaceSkinPNTOperator : hclBoneSpaceSkinOperator
    {
        public List<hclBoneSpaceDeformerLocalBlockPNT> m_localPNTs;
        public List<hclBoneSpaceDeformerLocalBlockUnpackedPNT> m_localUnpackedPNTs;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_localPNTs = des.ReadClassArray<hclBoneSpaceDeformerLocalBlockPNT>(br);
            m_localUnpackedPNTs = des.ReadClassArray<hclBoneSpaceDeformerLocalBlockUnpackedPNT>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_localPNTs);
            s.WriteClassArray(bw, m_localUnpackedPNTs);
        }
    }
}