using System.Collections.Generic;

namespace HKX2
{
    public class hclObjectSpaceMeshMeshDeformPOperator : hclObjectSpaceMeshMeshDeformOperator
    {
        public List<hclObjectSpaceDeformerLocalBlockP> m_localPs;
        public List<hclObjectSpaceDeformerLocalBlockUnpackedP> m_localUnpackedPs;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_localPs = des.ReadClassArray<hclObjectSpaceDeformerLocalBlockP>(br);
            m_localUnpackedPs = des.ReadClassArray<hclObjectSpaceDeformerLocalBlockUnpackedP>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_localPs);
            s.WriteClassArray(bw, m_localUnpackedPs);
        }
    }
}