using System.Numerics;

namespace HKX2
{
    public enum MotionType
    {
        MOTION_INVALID = 0,
        MOTION_DYNAMIC = 1,
        MOTION_SPHERE_INERTIA = 2,
        MOTION_BOX_INERTIA = 3,
        MOTION_KEYFRAMED = 4,
        MOTION_FIXED = 5,
        MOTION_THIN_BOX_INERTIA = 6,
        MOTION_CHARACTER = 7,
        MOTION_MAX_ID = 8
    }

    public class hkpMotion : hkReferencedObject
    {
        public Vector4 m_angularVelocity;
        public byte m_deactivationIntegrateCounter;
        public ushort m_deactivationNumInactiveFrames_0;
        public ushort m_deactivationNumInactiveFrames_1;
        public uint m_deactivationRefOrientation_0;
        public uint m_deactivationRefOrientation_1;
        public Vector4 m_deactivationRefPosition_0;
        public Vector4 m_deactivationRefPosition_1;
        public short m_gravityFactor;
        public Vector4 m_inertiaAndMassInv;
        public Vector4 m_linearVelocity;
        public hkMotionState m_motionState;
        public hkpMaxSizeMotion m_savedMotion;
        public ushort m_savedQualityTypeIndex;

        public MotionType m_type;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);

            // Return back to hkReferencedObject padded space
            if (des._header.PointerSize == 8) br.Position -= 4;

            m_type = (MotionType) br.ReadByte();
            m_deactivationIntegrateCounter = br.ReadByte();
            m_deactivationNumInactiveFrames_0 = br.ReadUInt16();
            m_deactivationNumInactiveFrames_1 = br.ReadUInt16();
            br.Pad(16);
            m_motionState = new hkMotionState();
            m_motionState.Read(des, br);
            m_inertiaAndMassInv = des.ReadVector4(br);
            m_linearVelocity = des.ReadVector4(br);
            m_angularVelocity = des.ReadVector4(br);
            m_deactivationRefPosition_0 = des.ReadVector4(br);
            m_deactivationRefPosition_1 = des.ReadVector4(br);
            m_deactivationRefOrientation_0 = br.ReadUInt32();
            m_deactivationRefOrientation_1 = br.ReadUInt32();
            m_savedMotion = des.ReadClassPointer<hkpMaxSizeMotion>(br);
            m_savedQualityTypeIndex = br.ReadUInt16();
            m_gravityFactor = br.ReadInt16();

            if (des._header.PointerSize == 8)
            {
                br.ReadUInt32();
                br.ReadUInt64();
            }
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);

            if (s._header.PointerSize == 8) bw.Position -= 4;

            bw.WriteByte((byte) m_type);
            bw.WriteByte(m_deactivationIntegrateCounter);
            bw.WriteUInt16(m_deactivationNumInactiveFrames_0);
            bw.WriteUInt16(m_deactivationNumInactiveFrames_1);
            bw.Pad(16);
            m_motionState.Write(s, bw);
            s.WriteVector4(bw, m_inertiaAndMassInv);
            s.WriteVector4(bw, m_linearVelocity);
            s.WriteVector4(bw, m_angularVelocity);
            s.WriteVector4(bw, m_deactivationRefPosition_0);
            s.WriteVector4(bw, m_deactivationRefPosition_1);
            bw.WriteUInt32(m_deactivationRefOrientation_0);
            bw.WriteUInt32(m_deactivationRefOrientation_1);
            s.WriteClassPointer(bw, m_savedMotion);
            bw.WriteUInt16(m_savedQualityTypeIndex);
            bw.WriteInt16(m_gravityFactor);

            if (s._header.PointerSize == 8)
            {
                bw.WriteUInt32(0);
                bw.WriteUInt64(0);
            }
        }
    }
}