using System.Numerics;

namespace HKX2
{
    public class hclCapsuleShape : hclShape
    {
        public float m_capLenSqrdInv;
        public Vector4 m_dir;
        public Vector4 m_end;
        public float m_radius;

        public Vector4 m_start;
        public override uint Signature => 0xDD03F524;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Pad(16);
            m_start = des.ReadVector4(br);
            m_end = des.ReadVector4(br);
            m_dir = des.ReadVector4(br);
            m_radius = br.ReadSingle();
            m_capLenSqrdInv = br.ReadSingle();
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Pad(16);
            s.WriteVector4(bw, m_start);
            s.WriteVector4(bw, m_end);
            s.WriteVector4(bw, m_dir);
            bw.WriteSingle(m_radius);
            bw.WriteSingle(m_capLenSqrdInv);
            bw.WriteUInt64(0);
        }
    }
}