using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public enum DebugValues
    {
        DEAD_FACE = -559023410,
        DEAD_EDGE = -559026834
    }

    public enum CutInfoValues
    {
        NOT_CUT_EDGE = 65535
    }

    public class hkaiNavMeshInstance : hkReferencedObject
    {
        public List<hkaiNavMeshClearanceCache> m_clearanceCaches;
        public List<ushort> m_cuttingInfo;
        public List<int> m_edgeMap;
        public List<byte> m_faceFlags;
        public List<int> m_faceMap;
        public List<int> m_instancedEdgeData;
        public List<hkaiNavMeshEdge> m_instancedEdges;
        public List<int> m_instancedFaceData;
        public List<hkaiNavMeshFace> m_instancedFaces;
        public uint m_layer;

        public hkaiNavMesh m_originalMesh;
        public List<int> m_ownedEdgeData;
        public List<hkaiNavMeshEdge> m_ownedEdges;
        public List<int> m_ownedFaceData;
        public List<hkaiNavMeshFace> m_ownedFaces;
        public List<Vector4> m_ownedVertices;
        public hkaiReferenceFrame m_referenceFrame;
        public int m_runtimeId;
        public uint m_sectionUid;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            m_originalMesh = des.ReadClassPointer<hkaiNavMesh>(br);
            br.ReadUInt64();
            m_referenceFrame = new hkaiReferenceFrame();
            m_referenceFrame.Read(des, br);
            m_edgeMap = des.ReadInt32Array(br);
            m_faceMap = des.ReadInt32Array(br);
            m_instancedFaces = des.ReadClassArray<hkaiNavMeshFace>(br);
            m_instancedEdges = des.ReadClassArray<hkaiNavMeshEdge>(br);
            m_ownedFaces = des.ReadClassArray<hkaiNavMeshFace>(br);
            m_ownedEdges = des.ReadClassArray<hkaiNavMeshEdge>(br);
            m_ownedVertices = des.ReadVector4Array(br);
            m_faceFlags = des.ReadByteArray(br);
            m_cuttingInfo = des.ReadUInt16Array(br);
            m_instancedFaceData = des.ReadInt32Array(br);
            m_instancedEdgeData = des.ReadInt32Array(br);
            m_ownedFaceData = des.ReadInt32Array(br);
            m_ownedEdgeData = des.ReadInt32Array(br);
            m_sectionUid = br.ReadUInt32();
            m_runtimeId = br.ReadInt32();
            m_layer = br.ReadUInt32();
            br.ReadUInt32();
            m_clearanceCaches = des.ReadClassPointerArray<hkaiNavMeshClearanceCache>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            s.WriteClassPointer(bw, m_originalMesh);
            bw.WriteUInt64(0);
            m_referenceFrame.Write(s, bw);
            s.WriteInt32Array(bw, m_edgeMap);
            s.WriteInt32Array(bw, m_faceMap);
            s.WriteClassArray(bw, m_instancedFaces);
            s.WriteClassArray(bw, m_instancedEdges);
            s.WriteClassArray(bw, m_ownedFaces);
            s.WriteClassArray(bw, m_ownedEdges);
            s.WriteVector4Array(bw, m_ownedVertices);
            s.WriteByteArray(bw, m_faceFlags);
            s.WriteUInt16Array(bw, m_cuttingInfo);
            s.WriteInt32Array(bw, m_instancedFaceData);
            s.WriteInt32Array(bw, m_instancedEdgeData);
            s.WriteInt32Array(bw, m_ownedFaceData);
            s.WriteInt32Array(bw, m_ownedEdgeData);
            bw.WriteUInt32(m_sectionUid);
            bw.WriteInt32(m_runtimeId);
            bw.WriteUInt32(m_layer);
            bw.WriteUInt32(0);
            s.WriteClassPointerArray(bw, m_clearanceCaches);
        }
    }
}