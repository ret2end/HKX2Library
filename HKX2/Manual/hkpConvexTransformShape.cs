using System.Numerics;

namespace HKX2
{
    public class hkpConvexTransformShape : hkpConvexTransformShapeBase
    {
        public Vector4 m_extraScale;

        public Matrix4x4 m_transform;
        public override uint Signature => 0x3AEAAA63;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Pad(16);
            m_transform = des.ReadQSTransform(br);
            m_extraScale = des.ReadVector4(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Pad(16);
            s.WriteQSTransform(bw, m_transform);
            s.WriteVector4(bw, m_extraScale);
        }
    }
}