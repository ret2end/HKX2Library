using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkpSimpleMeshShape : hkpShapeCollection
    {
        public List<byte> m_materialIndices;
        public float m_radius;
        public List<hkpSimpleMeshShapeTriangle> m_triangles;

        public List<Vector4> m_vertices;
        public WeldingType m_weldingType;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_vertices = des.ReadVector4Array(br);
            m_triangles = des.ReadClassArray<hkpSimpleMeshShapeTriangle>(br);
            m_materialIndices = des.ReadByteArray(br);
            m_radius = br.ReadSingle();
            m_weldingType = (WeldingType) br.ReadByte();
            br.ReadUInt16();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVector4Array(bw, m_vertices);
            s.WriteClassArray(bw, m_triangles);
            s.WriteByteArray(bw, m_materialIndices);
            bw.WriteSingle(m_radius);
            bw.WriteByte((byte) m_weldingType);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}