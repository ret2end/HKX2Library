using System.Collections.Generic;

namespace HKX2
{
    public class hkxMeshSection : hkReferencedObject
    {
        public List<hkMeshBoneIndexMapping> m_boneMatrixMap;
        public List<hkxIndexBuffer> m_indexBuffers;
        public List<float> m_linearKeyFrameHints;
        public hkxMaterial m_material;
        public List<hkReferencedObject> m_userChannels;
        public List<hkxVertexAnimation> m_vertexAnimations;

        public hkxVertexBuffer m_vertexBuffer;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_vertexBuffer = des.ReadClassPointer<hkxVertexBuffer>(br);
            m_indexBuffers = des.ReadClassPointerArray<hkxIndexBuffer>(br);
            m_material = des.ReadClassPointer<hkxMaterial>(br);
            m_userChannels = des.ReadClassPointerArray<hkReferencedObject>(br);
            m_vertexAnimations = des.ReadClassPointerArray<hkxVertexAnimation>(br);
            m_linearKeyFrameHints = des.ReadSingleArray(br);
            m_boneMatrixMap = des.ReadClassArray<hkMeshBoneIndexMapping>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_vertexBuffer);
            s.WriteClassPointerArray(bw, m_indexBuffers);
            s.WriteClassPointer(bw, m_material);
            s.WriteClassPointerArray(bw, m_userChannels);
            s.WriteClassPointerArray(bw, m_vertexAnimations);
            s.WriteSingleArray(bw, m_linearKeyFrameHints);
            s.WriteClassArray(bw, m_boneMatrixMap);
        }
    }
}