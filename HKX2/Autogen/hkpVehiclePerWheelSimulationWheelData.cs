using System.Numerics;

namespace HKX2
{
    public class hkpVehiclePerWheelSimulationWheelData : IHavokObject
    {
        public hkpWheelFrictionConstraintAtomAxle m_axle;
        public Vector4 m_contactLocal;
        public Vector4 m_forwardDirectionWs;
        public hkpWheelFrictionConstraintData m_frictionData;
        public Vector4 m_sideDirectionWs;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_axle = new hkpWheelFrictionConstraintAtomAxle();
            m_axle.Read(des, br);
            br.ReadUInt32();
            m_frictionData = new hkpWheelFrictionConstraintData();
            m_frictionData.Read(des, br);
            br.ReadUInt64();
            br.ReadUInt64();
            m_forwardDirectionWs = des.ReadVector4(br);
            m_sideDirectionWs = des.ReadVector4(br);
            m_contactLocal = des.ReadVector4(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_axle.Write(s, bw);
            bw.WriteUInt32(0);
            m_frictionData.Write(s, bw);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            s.WriteVector4(bw, m_forwardDirectionWs);
            s.WriteVector4(bw, m_sideDirectionWs);
            s.WriteVector4(bw, m_contactLocal);
        }
    }
}