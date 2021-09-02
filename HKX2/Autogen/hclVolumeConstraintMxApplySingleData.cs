using System.Numerics;

namespace HKX2
{
    public class hclVolumeConstraintMxApplySingleData : IHavokObject
    {
        public Vector4 m_frameVector;
        public ushort m_particleIndex;
        public float m_stiffness;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_frameVector = des.ReadVector4(br);
            m_particleIndex = br.ReadUInt16();
            br.ReadUInt16();
            m_stiffness = br.ReadSingle();
            br.ReadUInt64();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVector4(bw, m_frameVector);
            bw.WriteUInt16(m_particleIndex);
            bw.WriteUInt16(0);
            bw.WriteSingle(m_stiffness);
            bw.WriteUInt64(0);
        }
    }
}