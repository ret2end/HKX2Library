using System.Numerics;

namespace HKX2
{
    public class hkaiAvoidanceSolverBoundaryObstacle : IHavokObject
    {
        public Vector4 m_end;

        public Vector4 m_start;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_start = des.ReadVector4(br);
            m_end = des.ReadVector4(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVector4(bw, m_start);
            s.WriteVector4(bw, m_end);
        }
    }
}