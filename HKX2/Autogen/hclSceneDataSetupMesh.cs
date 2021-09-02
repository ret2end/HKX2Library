using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hclSceneDataSetupMesh : hclSetupMesh
    {
        public List<uint> m_edgeChannels;
        public List<hclSceneDataSetupMeshSection> m_meshBufferInterfaces;

        public hkxNode m_node;
        public hkxSkinBinding m_skinBinding;
        public List<uint> m_triangleChannels;
        public List<uint> m_vertexChannels;
        public Matrix4x4 m_worldFromMesh;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_node = des.ReadClassPointer<hkxNode>(br);
            br.ReadUInt64();
            m_worldFromMesh = des.ReadMatrix4(br);
            br.ReadUInt64();
            m_skinBinding = des.ReadClassPointer<hkxSkinBinding>(br);
            m_vertexChannels = des.ReadUInt32Array(br);
            m_triangleChannels = des.ReadUInt32Array(br);
            m_edgeChannels = des.ReadUInt32Array(br);
            m_meshBufferInterfaces = des.ReadClassPointerArray<hclSceneDataSetupMeshSection>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_node);
            bw.WriteUInt64(0);
            s.WriteMatrix4(bw, m_worldFromMesh);
            bw.WriteUInt64(0);
            s.WriteClassPointer(bw, m_skinBinding);
            s.WriteUInt32Array(bw, m_vertexChannels);
            s.WriteUInt32Array(bw, m_triangleChannels);
            s.WriteUInt32Array(bw, m_edgeChannels);
            s.WriteClassPointerArray(bw, m_meshBufferInterfaces);
        }
    }
}