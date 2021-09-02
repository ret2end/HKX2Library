using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hclObjectSpaceMeshMeshDeformOperator : hclOperator
    {
        public enum ScaleNormalBehaviour
        {
            SCALE_NORMAL_IGNORE = 0,
            SCALE_NORMAL_APPLY = 1,
            SCALE_NORMAL_INVERT = 2
        }

        public bool m_customSkinDeform;

        public uint m_inputBufferIdx;
        public List<ushort> m_inputTrianglesSubset;
        public hclObjectSpaceDeformer m_objectSpaceDeformer;
        public uint m_outputBufferIdx;
        public ScaleNormalBehaviour m_scaleNormalBehaviour;
        public List<Matrix4x4> m_triangleFromMeshTransforms;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_inputBufferIdx = br.ReadUInt32();
            m_outputBufferIdx = br.ReadUInt32();
            m_scaleNormalBehaviour = (ScaleNormalBehaviour) br.ReadUInt32();
            m_inputTrianglesSubset = des.ReadUInt16Array(br);
            m_triangleFromMeshTransforms = des.ReadMatrix4Array(br);
            m_objectSpaceDeformer = new hclObjectSpaceDeformer();
            m_objectSpaceDeformer.Read(des, br);
            m_customSkinDeform = br.ReadBoolean();
            br.ReadUInt32();
            br.ReadUInt16();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt32(m_inputBufferIdx);
            bw.WriteUInt32(m_outputBufferIdx);
            bw.WriteUInt32((uint) m_scaleNormalBehaviour);
            s.WriteUInt16Array(bw, m_inputTrianglesSubset);
            s.WriteMatrix4Array(bw, m_triangleFromMeshTransforms);
            m_objectSpaceDeformer.Write(s, bw);
            bw.WriteBoolean(m_customSkinDeform);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}