using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkaiEdgeGeometry : hkReferencedObject
    {
        public enum FaceFlagBits
        {
            FLAGS_NONE = 0,
            FLAGS_INPUT_GEOMETRY = 1,
            FLAGS_PAINTER = 2,
            FLAGS_CARVER = 4,
            FLAGS_EXTRUDED = 8,
            FLAGS_ALL = 15
        }

        public List<hkaiEdgeGeometryEdge> m_edges;
        public List<hkaiEdgeGeometryFace> m_faces;
        public List<Vector4> m_vertices;
        public hkaiEdgeGeometryFace m_zeroFace;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_edges = des.ReadClassArray<hkaiEdgeGeometryEdge>(br);
            m_faces = des.ReadClassArray<hkaiEdgeGeometryFace>(br);
            m_vertices = des.ReadVector4Array(br);
            m_zeroFace = new hkaiEdgeGeometryFace();
            m_zeroFace.Read(des, br);
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_edges);
            s.WriteClassArray(bw, m_faces);
            s.WriteVector4Array(bw, m_vertices);
            m_zeroFace.Write(s, bw);
            bw.WriteUInt32(0);
        }
    }
}