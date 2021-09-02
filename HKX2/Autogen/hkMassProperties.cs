using System.Numerics;

namespace HKX2
{
    public class hkMassProperties : IHavokObject
    {
        public Vector4 m_centerOfMass;
        public Matrix4x4 m_inertiaTensor;
        public float m_mass;

        public float m_volume;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_volume = br.ReadSingle();
            m_mass = br.ReadSingle();
            br.ReadUInt64();
            m_centerOfMass = des.ReadVector4(br);
            m_inertiaTensor = des.ReadMatrix3(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_volume);
            bw.WriteSingle(m_mass);
            bw.WriteUInt64(0);
            s.WriteVector4(bw, m_centerOfMass);
            s.WriteMatrix3(bw, m_inertiaTensor);
        }
    }
}