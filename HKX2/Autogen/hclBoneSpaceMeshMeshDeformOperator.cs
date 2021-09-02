using System.Collections.Generic;

namespace HKX2
{
    public enum ScaleNormalBehaviour
    {
        SCALE_NORMAL_IGNORE = 0,
        SCALE_NORMAL_APPLY = 1,
        SCALE_NORMAL_INVERT = 2
    }

    public class hclBoneSpaceMeshMeshDeformOperator : hclOperator
    {
        public hclBoneSpaceDeformer m_boneSpaceDeformer;

        public uint m_inputBufferIdx;
        public List<ushort> m_inputTrianglesSubset;
        public uint m_outputBufferIdx;
        public ScaleNormalBehaviour m_scaleNormalBehaviour;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_inputBufferIdx = br.ReadUInt32();
            m_outputBufferIdx = br.ReadUInt32();
            m_scaleNormalBehaviour = (ScaleNormalBehaviour) br.ReadUInt32();
            m_inputTrianglesSubset = des.ReadUInt16Array(br);
            m_boneSpaceDeformer = new hclBoneSpaceDeformer();
            m_boneSpaceDeformer.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt32(m_inputBufferIdx);
            bw.WriteUInt32(m_outputBufferIdx);
            bw.WriteUInt32((uint) m_scaleNormalBehaviour);
            s.WriteUInt16Array(bw, m_inputTrianglesSubset);
            m_boneSpaceDeformer.Write(s, bw);
        }
    }
}