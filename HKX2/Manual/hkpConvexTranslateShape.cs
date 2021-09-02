using System.Numerics;

namespace HKX2
{
    public class hkpConvexTranslateShape : hkpConvexTransformShapeBase
    {
        public Vector4 m_translation;
        public override uint Signature => 0xA3F8BF6A;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Pad(16);
            m_translation = des.ReadVector4(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Pad(16);
            s.WriteVector4(bw, m_translation);
        }
    }
}