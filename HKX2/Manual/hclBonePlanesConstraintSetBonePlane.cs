using System.Numerics;

namespace HKX2
{
    public class hclBonePlanesConstraintSetBonePlane : IHavokObject
    {
        public ushort m_particleIndex;

        public Vector4 m_planeEquationBone;
        public float m_stiffness;
        public ushort m_transformIndex;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_planeEquationBone = des.ReadVector4(br);
            m_particleIndex = br.ReadUInt16();
            m_transformIndex = br.ReadUInt16();
            m_stiffness = br.ReadSingle();
            br.ReadUInt64();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVector4(bw, m_planeEquationBone);
            bw.WriteUInt16(m_particleIndex);
            bw.WriteUInt16(m_transformIndex);
            bw.WriteSingle(m_stiffness);
            bw.WriteUInt64(0);
        }
    }
}