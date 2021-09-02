using System.Numerics;

namespace HKX2
{
    public class hkaiReferenceFrame : IHavokObject
    {
        public Vector4 m_angularVelocity;
        public Vector4 m_linearVelocity;

        public Matrix4x4 m_transform;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_transform = des.ReadTransform(br);
            m_linearVelocity = des.ReadVector4(br);
            m_angularVelocity = des.ReadVector4(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteTransform(bw, m_transform);
            s.WriteVector4(bw, m_linearVelocity);
            s.WriteVector4(bw, m_angularVelocity);
        }
    }
}