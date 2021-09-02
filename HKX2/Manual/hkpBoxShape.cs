using System.Numerics;

namespace HKX2
{
    public class hkpBoxShape : hkpConvexShape
    {
        public Vector4 m_halfExtents;
        public override uint Signature => 0xDCA2D1A7;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Pad(16);
            m_halfExtents = des.ReadVector4(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Pad(16);
            s.WriteVector4(bw, m_halfExtents);
        }
    }
}