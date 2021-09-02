using System.Numerics;

namespace HKX2
{
    public class hkpSetLocalTransformsConstraintAtom : hkpConstraintAtom
    {
        public Matrix4x4 m_transformA;
        public Matrix4x4 m_transformB;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Pad(16);
            m_transformA = des.ReadTransform(br);
            m_transformB = des.ReadTransform(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Pad(16);
            s.WriteTransform(bw, m_transformA);
            s.WriteTransform(bw, m_transformB);
        }
    }
}