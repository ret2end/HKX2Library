using System.Numerics;

namespace HKX2
{
    public class hkpTyremarkPoint : IHavokObject
    {
        public Vector4 m_pointLeft;
        public Vector4 m_pointRight;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_pointLeft = des.ReadVector4(br);
            m_pointRight = des.ReadVector4(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVector4(bw, m_pointLeft);
            s.WriteVector4(bw, m_pointRight);
        }
    }
}