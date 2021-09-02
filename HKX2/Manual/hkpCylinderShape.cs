using System.Numerics;

namespace HKX2
{
    public enum VertexIdEncoding
    {
        VERTEX_ID_ENCODING_IS_BASE_A_SHIFT = 7,
        VERTEX_ID_ENCODING_SIN_SIGN_SHIFT = 6,
        VERTEX_ID_ENCODING_COS_SIGN_SHIFT = 5,
        VERTEX_ID_ENCODING_IS_SIN_LESSER_SHIFT = 4,
        VERTEX_ID_ENCODING_VALUE_MASK = 15
    }

    public class hkpCylinderShape : hkpConvexShape
    {
        public float m_cylBaseRadiusFactorForHeightFieldCollisions;

        public float m_cylRadius;
        public Vector4 m_perpendicular1;
        public Vector4 m_perpendicular2;
        public Vector4 m_vertexA;
        public Vector4 m_vertexB;
        public override uint Signature => 0xFAAE1F08;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);

            if (des._header.PointerSize == 8) br.Position -= 4;

            m_cylRadius = br.ReadSingle();
            m_cylBaseRadiusFactorForHeightFieldCollisions = br.ReadSingle();
            br.Pad(16);
            m_vertexA = des.ReadVector4(br);
            m_vertexB = des.ReadVector4(br);
            m_perpendicular1 = des.ReadVector4(br);
            m_perpendicular2 = des.ReadVector4(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);

            if (s._header.PointerSize == 8) bw.Position -= 4;

            bw.WriteSingle(m_cylRadius);
            bw.WriteSingle(m_cylBaseRadiusFactorForHeightFieldCollisions);
            bw.Pad(16);
            s.WriteVector4(bw, m_vertexA);
            s.WriteVector4(bw, m_vertexB);
            s.WriteVector4(bw, m_perpendicular1);
            s.WriteVector4(bw, m_perpendicular2);
        }
    }
}