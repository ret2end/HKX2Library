using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public enum GeometryType
    {
        GEOMETRY_STATIC = 0,
        GEOMETRY_DYNAMIC_VERTICES = 1
    }

    public class hkGeometry : hkReferencedObject
    {
        public List<hkGeometryTriangle> m_triangles;

        public List<Vector4> m_vertices;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_vertices = des.ReadVector4Array(br);
            m_triangles = des.ReadClassArray<hkGeometryTriangle>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVector4Array(bw, m_vertices);
            s.WriteClassArray(bw, m_triangles);
        }
    }
}