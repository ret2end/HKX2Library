using System.Numerics;

namespace HKX2
{
    public class hclSimClothDataOverridableSimulationInfo : IHavokObject
    {
        public float m_collisionTolerance;
        public float m_globalDampingPerSecond;

        public Vector4 m_gravity;
        public bool m_landscapeCollisionEnabled;
        public bool m_pinchDetectionEnabled;
        public uint m_subSteps;
        public bool m_transferMotionEnabled;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            br.Pad(16);
            m_gravity = des.ReadVector4(br);
            m_globalDampingPerSecond = br.ReadSingle();
            m_collisionTolerance = br.ReadSingle();
            m_subSteps = br.ReadUInt32();
            m_pinchDetectionEnabled = br.ReadBoolean();
            m_landscapeCollisionEnabled = br.ReadBoolean();
            m_transferMotionEnabled = br.ReadBoolean();
            br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.Pad(16);
            s.WriteVector4(bw, m_gravity);
            bw.WriteSingle(m_globalDampingPerSecond);
            bw.WriteSingle(m_collisionTolerance);
            bw.WriteUInt32(m_subSteps);
            bw.WriteBoolean(m_pinchDetectionEnabled);
            bw.WriteBoolean(m_landscapeCollisionEnabled);
            bw.WriteBoolean(m_transferMotionEnabled);
            bw.WriteByte(0);
        }
    }
}