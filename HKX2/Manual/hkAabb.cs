using System.Numerics;

namespace HKX2
{
    public class hkAabb : IHavokObject
    {
        public Vector4 m_max;

        public Vector4 m_min;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_min = des.ReadVector4(br);
            m_max = des.ReadVector4(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVector4(bw, m_min);
            s.WriteVector4(bw, m_max);
        }
    }
}