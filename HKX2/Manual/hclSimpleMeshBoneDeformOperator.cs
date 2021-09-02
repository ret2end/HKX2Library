using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hclSimpleMeshBoneDeformOperator : hclOperator
    {
        public uint m_inputBufferIdx;
        public List<Matrix4x4> m_localBoneTransforms;
        public uint m_outputTransformSetIdx;
        public List<hclSimpleMeshBoneDeformOperatorTriangleBonePair> m_triangleBonePairs;
        public override uint Signature => 0x80D9769F;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);

            if (des._header.PointerSize == 8) br.Position -= 4;

            m_inputBufferIdx = br.ReadUInt32();
            m_outputTransformSetIdx = br.ReadUInt32();
            m_triangleBonePairs = des.ReadClassArray<hclSimpleMeshBoneDeformOperatorTriangleBonePair>(br);
            m_localBoneTransforms = des.ReadMatrix4Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);

            if (s._header.PointerSize == 8) bw.Position -= 4;

            bw.WriteUInt32(m_inputBufferIdx);
            bw.WriteUInt32(m_outputTransformSetIdx);
            s.WriteClassArray(bw, m_triangleBonePairs);
            s.WriteMatrix4Array(bw, m_localBoneTransforms);
        }
    }
}