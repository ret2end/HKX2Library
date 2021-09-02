using System.Numerics;

namespace HKX2
{
    public class hkSphere : IHavokObject
    {
        public Vector4 m_pos;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            br.Pad(16);
            m_pos = des.ReadVector4(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.Pad(16);
            s.WriteVector4(bw, m_pos);
        }
    }
}