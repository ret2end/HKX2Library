using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hclStorageSetupMeshSection : hkReferencedObject
    {
        public List<Vector4> m_bitangents;
        public List<hclStorageSetupMeshSectionBoneInfluences> m_boneInfluences;
        public List<ushort> m_normalIDs;
        public List<Vector4> m_normals;

        public hclSetupMesh m_parentSetupMesh;
        public List<hclStorageSetupMeshSectionSectionEdgeSelectionChannel> m_sectionEdgeChannels;
        public List<hclStorageSetupMeshSectionSectionTriangleSelectionChannel> m_sectionTriangleChannels;
        public List<hclStorageSetupMeshSectionSectionVertexChannel> m_sectionVertexChannels;
        public List<Vector4> m_tangents;
        public List<hclSetupMeshSectionTriangle> m_triangles;
        public List<Vector4> m_vertices;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            m_parentSetupMesh = des.ReadClassPointer<hclSetupMesh>(br);
            m_vertices = des.ReadVector4Array(br);
            m_normals = des.ReadVector4Array(br);
            m_tangents = des.ReadVector4Array(br);
            m_bitangents = des.ReadVector4Array(br);
            m_triangles = des.ReadClassArray<hclSetupMeshSectionTriangle>(br);
            m_sectionVertexChannels = des.ReadClassPointerArray<hclStorageSetupMeshSectionSectionVertexChannel>(br);
            m_sectionEdgeChannels =
                des.ReadClassPointerArray<hclStorageSetupMeshSectionSectionEdgeSelectionChannel>(br);
            m_sectionTriangleChannels =
                des.ReadClassPointerArray<hclStorageSetupMeshSectionSectionTriangleSelectionChannel>(br);
            m_boneInfluences = des.ReadClassPointerArray<hclStorageSetupMeshSectionBoneInfluences>(br);
            m_normalIDs = des.ReadUInt16Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            s.WriteClassPointer(bw, m_parentSetupMesh);
            s.WriteVector4Array(bw, m_vertices);
            s.WriteVector4Array(bw, m_normals);
            s.WriteVector4Array(bw, m_tangents);
            s.WriteVector4Array(bw, m_bitangents);
            s.WriteClassArray(bw, m_triangles);
            s.WriteClassPointerArray(bw, m_sectionVertexChannels);
            s.WriteClassPointerArray(bw, m_sectionEdgeChannels);
            s.WriteClassPointerArray(bw, m_sectionTriangleChannels);
            s.WriteClassPointerArray(bw, m_boneInfluences);
            s.WriteUInt16Array(bw, m_normalIDs);
        }
    }
}