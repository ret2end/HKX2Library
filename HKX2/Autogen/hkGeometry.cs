using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkGeometry Signatire: 0x98dd8bdc size: 32 flags: FLAGS_NONE

    // m_vertices m_class:  Type.TYPE_ARRAY Type.TYPE_VECTOR4 arrSize: 0 offset: 0 flags:  enum: 
    // m_triangles m_class: hkGeometryTriangle Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkGeometry : IHavokObject
    {

        public List<Vector4> m_vertices;
        public List<hkGeometryTriangle> m_triangles;

        public uint Signature => 0x98dd8bdc;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_vertices = des.ReadVector4Array(br);
            m_triangles = des.ReadClassArray<hkGeometryTriangle>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteVector4Array(bw, m_vertices);
            s.WriteClassArray<hkGeometryTriangle>(bw, m_triangles);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

