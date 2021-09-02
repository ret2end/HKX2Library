namespace HKX2
{
    public enum FindContacts
    {
        FIND_CONTACTS_DEFAULT = 0,
        FIND_CONTACTS_EXTRA = 1
    }

    public enum ResetCollisionInformation
    {
        RESET_TOI = 1,
        RESET_TIM = 2,
        RESET_AABB = 4,
        RESET_ALL = 7
    }

    public enum LastProcessingStep
    {
        INTEGRATE = 0,
        COLLIDE = 1
    }

    public class hkpSimulation : hkReferencedObject
    {
        public float m_currentPsiTime;
        public float m_currentTime;

        public uint m_determinismCheckFrameCounter;
        public float m_frameMarkerPsiSnap;
        public LastProcessingStep m_lastProcessingStep;
        public float m_physicsDeltaTime;
        public uint m_previousStepResult;
        public float m_simulateUntilTime;
        public hkpWorld m_world;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_determinismCheckFrameCounter = br.ReadUInt32();
            m_world = des.ReadClassPointer<hkpWorld>(br);
            m_lastProcessingStep = (LastProcessingStep) br.ReadByte();
            br.ReadUInt16();
            br.ReadByte();
            m_currentTime = br.ReadSingle();
            m_currentPsiTime = br.ReadSingle();
            m_physicsDeltaTime = br.ReadSingle();
            m_simulateUntilTime = br.ReadSingle();
            m_frameMarkerPsiSnap = br.ReadSingle();
            m_previousStepResult = br.ReadUInt32();
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt32(m_determinismCheckFrameCounter);
            s.WriteClassPointer(bw, m_world);
            bw.WriteByte((byte) m_lastProcessingStep);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            bw.WriteSingle(m_currentTime);
            bw.WriteSingle(m_currentPsiTime);
            bw.WriteSingle(m_physicsDeltaTime);
            bw.WriteSingle(m_simulateUntilTime);
            bw.WriteSingle(m_frameMarkerPsiSnap);
            bw.WriteUInt32(m_previousStepResult);
            bw.WriteUInt32(0);
        }
    }
}