using System.Collections.Generic;

namespace HKX2
{
    public class hclBoneSpaceSkinPOperator : hclBoneSpaceSkinOperator
    {
        public List<hclBoneSpaceDeformerLocalBlockP> m_localPs;
        public List<hclBoneSpaceDeformerLocalBlockUnpackedP> m_localUnpackedPs;
        public override uint Signature => 0x557518BD;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_localPs = des.ReadClassArray<hclBoneSpaceDeformerLocalBlockP>(br);
            m_localUnpackedPs = des.ReadClassArray<hclBoneSpaceDeformerLocalBlockUnpackedP>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_localPs);
            s.WriteClassArray(bw, m_localUnpackedPs);
        }
    }
}