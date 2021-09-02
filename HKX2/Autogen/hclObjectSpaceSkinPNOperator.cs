using System.Collections.Generic;

namespace HKX2
{
    public class hclObjectSpaceSkinPNOperator : hclObjectSpaceSkinOperator
    {
        public List<hclObjectSpaceDeformerLocalBlockPN> m_localPNs;
        public List<hclObjectSpaceDeformerLocalBlockUnpackedPN> m_localUnpackedPNs;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_localPNs = des.ReadClassArray<hclObjectSpaceDeformerLocalBlockPN>(br);
            m_localUnpackedPNs = des.ReadClassArray<hclObjectSpaceDeformerLocalBlockUnpackedPN>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_localPNs);
            s.WriteClassArray(bw, m_localUnpackedPNs);
        }
    }
}