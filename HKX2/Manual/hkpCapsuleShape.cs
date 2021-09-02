using System.Numerics;

namespace HKX2
{
    public enum RayHitType
    {
        HIT_CAP0 = 0,
        HIT_CAP1 = 1,
        HIT_BODY = 2
    }

    public class hkpCapsuleShape : hkpConvexShape
    {
        public Vector4 m_vertexA;
        public Vector4 m_vertexB;
        public override uint Signature => 0xFDA179F3;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Pad(16);
            m_vertexA = des.ReadVector4(br);
            m_vertexB = des.ReadVector4(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Pad(16);
            s.WriteVector4(bw, m_vertexA);
            s.WriteVector4(bw, m_vertexB);
        }
    }
}