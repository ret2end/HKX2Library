using System.Collections.Generic;

namespace HKX2
{
    public class hclMeshBoneDeformOperator : hclOperator
    {
        public uint m_inputBufferIdx;
        public uint m_outputTransformSetIdx;
        public List<hclMeshBoneDeformOperatorTriangleBonePair> m_triangleBonePairs;
        public List<ushort> m_triangleBoneStartForBone;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_inputBufferIdx = br.ReadUInt32();
            m_outputTransformSetIdx = br.ReadUInt32();
            br.ReadUInt32();
            m_triangleBonePairs = des.ReadClassArray<hclMeshBoneDeformOperatorTriangleBonePair>(br);
            m_triangleBoneStartForBone = des.ReadUInt16Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt32(m_inputBufferIdx);
            bw.WriteUInt32(m_outputTransformSetIdx);
            bw.WriteUInt32(0);
            s.WriteClassArray(bw, m_triangleBonePairs);
            s.WriteUInt16Array(bw, m_triangleBoneStartForBone);
        }
    }
}