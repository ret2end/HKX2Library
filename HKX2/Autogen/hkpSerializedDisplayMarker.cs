using System.Numerics;

namespace HKX2
{
    public class hkpSerializedDisplayMarker : hkReferencedObject
    {
        public Matrix4x4 m_transform;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_transform = des.ReadTransform(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteTransform(bw, m_transform);
        }
    }
}