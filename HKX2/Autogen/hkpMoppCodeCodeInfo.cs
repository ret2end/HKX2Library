using System.Numerics;

namespace HKX2
{
    public class hkpMoppCodeCodeInfo : IHavokObject
    {
        public Vector4 m_offset;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_offset = des.ReadVector4(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVector4(bw, m_offset);
        }
    }
}