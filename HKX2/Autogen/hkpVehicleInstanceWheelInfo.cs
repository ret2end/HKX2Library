using System.Numerics;

namespace HKX2
{
    public class hkpVehicleInstanceWheelInfo : IHavokObject
    {
        public float m_contactFriction;

        public hkContactPoint m_contactPoint;
        public uint m_contactShapeKey_0;
        public uint m_contactShapeKey_1;
        public uint m_contactShapeKey_2;
        public uint m_contactShapeKey_3;
        public uint m_contactShapeKey_4;
        public uint m_contactShapeKey_5;
        public uint m_contactShapeKey_6;
        public uint m_contactShapeKey_7;
        public float m_currentSuspensionLength;
        public float m_forwardSlipVelocity;
        public Vector4 m_hardPointWs;
        public float m_noSlipIdealSpinVelocity;
        public Vector4 m_rayEndPointWs;
        public float m_sideForce;
        public float m_sideSlipVelocity;
        public float m_skidEnergyDensity;
        public float m_spinAngle;
        public Vector4 m_spinAxisChassisSpace;
        public Vector4 m_spinAxisWs;
        public float m_spinVelocity;
        public Quaternion m_steeringOrientationChassisSpace;
        public Vector4 m_suspensionDirectionWs;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_contactPoint = new hkContactPoint();
            m_contactPoint.Read(des, br);
            m_contactFriction = br.ReadSingle();
            br.ReadUInt64();
            br.ReadUInt32();
            m_contactShapeKey_0 = br.ReadUInt32();
            m_contactShapeKey_1 = br.ReadUInt32();
            m_contactShapeKey_2 = br.ReadUInt32();
            m_contactShapeKey_3 = br.ReadUInt32();
            m_contactShapeKey_4 = br.ReadUInt32();
            m_contactShapeKey_5 = br.ReadUInt32();
            m_contactShapeKey_6 = br.ReadUInt32();
            m_contactShapeKey_7 = br.ReadUInt32();
            m_hardPointWs = des.ReadVector4(br);
            m_rayEndPointWs = des.ReadVector4(br);
            m_currentSuspensionLength = br.ReadSingle();
            br.ReadUInt64();
            br.ReadUInt32();
            m_suspensionDirectionWs = des.ReadVector4(br);
            m_spinAxisChassisSpace = des.ReadVector4(br);
            m_spinAxisWs = des.ReadVector4(br);
            m_steeringOrientationChassisSpace = des.ReadQuaternion(br);
            m_spinVelocity = br.ReadSingle();
            m_noSlipIdealSpinVelocity = br.ReadSingle();
            m_spinAngle = br.ReadSingle();
            m_skidEnergyDensity = br.ReadSingle();
            m_sideForce = br.ReadSingle();
            m_forwardSlipVelocity = br.ReadSingle();
            m_sideSlipVelocity = br.ReadSingle();
            br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_contactPoint.Write(s, bw);
            bw.WriteSingle(m_contactFriction);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            bw.WriteUInt32(m_contactShapeKey_0);
            bw.WriteUInt32(m_contactShapeKey_1);
            bw.WriteUInt32(m_contactShapeKey_2);
            bw.WriteUInt32(m_contactShapeKey_3);
            bw.WriteUInt32(m_contactShapeKey_4);
            bw.WriteUInt32(m_contactShapeKey_5);
            bw.WriteUInt32(m_contactShapeKey_6);
            bw.WriteUInt32(m_contactShapeKey_7);
            s.WriteVector4(bw, m_hardPointWs);
            s.WriteVector4(bw, m_rayEndPointWs);
            bw.WriteSingle(m_currentSuspensionLength);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            s.WriteVector4(bw, m_suspensionDirectionWs);
            s.WriteVector4(bw, m_spinAxisChassisSpace);
            s.WriteVector4(bw, m_spinAxisWs);
            s.WriteQuaternion(bw, m_steeringOrientationChassisSpace);
            bw.WriteSingle(m_spinVelocity);
            bw.WriteSingle(m_noSlipIdealSpinVelocity);
            bw.WriteSingle(m_spinAngle);
            bw.WriteSingle(m_skidEnergyDensity);
            bw.WriteSingle(m_sideForce);
            bw.WriteSingle(m_forwardSlipVelocity);
            bw.WriteSingle(m_sideSlipVelocity);
            bw.WriteUInt32(0);
        }
    }
}