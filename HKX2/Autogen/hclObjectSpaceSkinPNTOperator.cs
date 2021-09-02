using System.Collections.Generic;

namespace HKX2
{
    public class hclObjectSpaceSkinPNTOperator : hclObjectSpaceSkinOperator
    {
        public List<hclObjectSpaceDeformerLocalBlockPNT> m_localPNTs;
        public List<hclObjectSpaceDeformerLocalBlockUnpackedPNT> m_localUnpackedPNTs;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_localPNTs = des.ReadClassArray<hclObjectSpaceDeformerLocalBlockPNT>(br);
            m_localUnpackedPNTs = des.ReadClassArray<hclObjectSpaceDeformerLocalBlockUnpackedPNT>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_localPNTs);
            s.WriteClassArray(bw, m_localUnpackedPNTs);
        }
    }
}