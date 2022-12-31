using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkGeometry Signatire: 0x98dd8bdc size: 32 flags: FLAGS_NONE

    // m_vertices m_class:  Type.TYPE_ARRAY Type.TYPE_VECTOR4 arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_triangles m_class: hkGeometryTriangle Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkGeometry : IHavokObject
    {
        public List<Vector4> m_vertices;
        public List<hkGeometryTriangle> m_triangles;

        public virtual uint Signature => 0x98dd8bdc;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_vertices = des.ReadVector4Array(br);
            m_triangles = des.ReadClassArray<hkGeometryTriangle>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVector4Array(bw, m_vertices);
            s.WriteClassArray<hkGeometryTriangle>(bw, m_triangles);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteVector4Array(xe, nameof(m_vertices), m_vertices);
            xs.WriteClassArray<hkGeometryTriangle>(xe, nameof(m_triangles), m_triangles);
        }
    }
}

