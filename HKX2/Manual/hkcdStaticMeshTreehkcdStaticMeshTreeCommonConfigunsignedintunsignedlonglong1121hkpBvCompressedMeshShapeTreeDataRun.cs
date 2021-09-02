using System.Collections.Generic;

namespace HKX2
{
    public class
        hkcdStaticMeshTreehkcdStaticMeshTreeCommonConfigunsignedintunsignedlonglong1121hkpBvCompressedMeshShapeTreeDataRun :
            hkcdStaticMeshTreeBase
    {
        public enum TriangleMaterial
        {
            TM_SET_FROM_TRIANGLE_DATA_TYPE = 0,
            TM_SET_FROM_PRIMITIVE_KEY = 1
        }

        public List<uint> m_packedVertices;
        public List<hkpBvCompressedMeshShapeTreeDataRun> m_primitiveDataRuns;
        public List<ulong> m_sharedVertices;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_packedVertices = des.ReadUInt32Array(br);
            m_sharedVertices = des.ReadUInt64Array(br);
            m_primitiveDataRuns = des.ReadClassArray<hkpBvCompressedMeshShapeTreeDataRun>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteUInt32Array(bw, m_packedVertices);
            s.WriteUInt64Array(bw, m_sharedVertices);
            s.WriteClassArray(bw, m_primitiveDataRuns);
        }
    }
}