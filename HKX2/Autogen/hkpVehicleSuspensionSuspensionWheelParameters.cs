using System.Numerics;

namespace HKX2
{
    public class hkpVehicleSuspensionSuspensionWheelParameters : IHavokObject
    {
        public Vector4 m_directionChassisSpace;

        public Vector4 m_hardpointChassisSpace;
        public float m_length;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_hardpointChassisSpace = des.ReadVector4(br);
            m_directionChassisSpace = des.ReadVector4(br);
            m_length = br.ReadSingle();
            br.ReadUInt64();
            br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVector4(bw, m_hardpointChassisSpace);
            s.WriteVector4(bw, m_directionChassisSpace);
            bw.WriteSingle(m_length);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
        }
    }
}