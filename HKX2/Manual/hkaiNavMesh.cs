using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public enum NavMeshFlagBits
    {
        MESH_NONE = 0,
        MESH_CLIMBING = 1
    }

    public enum EdgeFlagBits
    {
        EDGE_SILHOUETTE = 1,
        EDGE_RETRIANGULATED = 2,
        EDGE_ORIGINAL = 4,
        OPPOSITE_EDGE_UNLOADED_UNUSED = 8,
        EDGE_USER = 16,
        EDGE_BLOCKED = 32,
        EDGE_EXTERNAL_OPPOSITE = 64
    }

    public class hkaiNavMesh : hkReferencedObject
    {
        public enum Constants
        {
            INVALID_REGION_INDEX = -1,
            INVALID_FACE_INDEX = -1,
            INVALID_EDGE_INDEX = -1,
            INVALID_VERTEX_INDEX = -1,
            MAX_DATA_PER_EDGE = 4,
            MAX_DATA_PER_FACE = 4
        }

        public enum FaceFlagBits
        {
            FACE_HIDDEN = 1,
            FACE_CUT = 2,
            FACE_STREAMING = 4
        }

        public hkAabb m_aabb;
        public List<int> m_edgeData;
        public int m_edgeDataStriding;
        public List<hkaiNavMeshEdge> m_edges;
        public float m_erosionRadius;
        public List<int> m_faceData;
        public int m_faceDataStriding;

        public List<hkaiNavMeshFace> m_faces;
        public NavMeshFlagBits m_flags;
        public List<hkaiStreamingSet> m_streamingSets;
        public ulong m_userData;
        public List<Vector4> m_vertices;
        public override uint Signature => 0x6D493BDB;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_faces = des.ReadClassArray<hkaiNavMeshFace>(br);
            m_edges = des.ReadClassArray<hkaiNavMeshEdge>(br);
            m_vertices = des.ReadVector4Array(br);
            m_streamingSets = des.ReadClassArray<hkaiStreamingSet>(br);
            m_faceData = des.ReadInt32Array(br);
            m_edgeData = des.ReadInt32Array(br);
            m_faceDataStriding = br.ReadInt32();
            m_edgeDataStriding = br.ReadInt32();
            m_flags = (NavMeshFlagBits) br.ReadByte();
            br.Pad(16);
            m_aabb = new hkAabb();
            m_aabb.Read(des, br);
            m_erosionRadius = br.ReadSingle();

            if (des._header.PointerSize == 8) br.ReadUInt32();

            m_userData = br.ReadUSize();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_faces);
            s.WriteClassArray(bw, m_edges);
            s.WriteVector4Array(bw, m_vertices);
            s.WriteClassArray(bw, m_streamingSets);
            s.WriteInt32Array(bw, m_faceData);
            s.WriteInt32Array(bw, m_edgeData);
            bw.WriteInt32(m_faceDataStriding);
            bw.WriteInt32(m_edgeDataStriding);
            bw.WriteByte((byte) m_flags);
            bw.Pad(16);
            m_aabb.Write(s, bw);
            bw.WriteSingle(m_erosionRadius);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);

            bw.WriteUSize(m_userData);
        }
    }
}