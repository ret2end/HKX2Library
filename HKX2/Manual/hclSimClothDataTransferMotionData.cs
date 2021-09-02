namespace HKX2
{
    public class hclSimClothDataTransferMotionData : IHavokObject
    {
        public float m_maxRotationBlend;
        public float m_maxRotationSpeed;
        public float m_maxTranslationBlend;
        public float m_maxTranslationSpeed;
        public float m_minRotationBlend;
        public float m_minRotationSpeed;
        public float m_minTranslationBlend;
        public float m_minTranslationSpeed;
        public bool m_transferRotationMotion;
        public bool m_transferTranslationMotion;
        public uint m_transformIndex;

        public uint m_transformSetIndex;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_transformSetIndex = br.ReadUInt32();
            m_transformIndex = br.ReadUInt32();
            m_transferTranslationMotion = br.ReadBoolean();
            br.ReadByte();
            br.ReadUInt16();
            m_minTranslationSpeed = br.ReadSingle();
            m_maxTranslationSpeed = br.ReadSingle();
            m_minTranslationBlend = br.ReadSingle();
            m_maxTranslationBlend = br.ReadSingle();
            m_transferRotationMotion = br.ReadBoolean();
            br.ReadByte();
            br.ReadUInt16();
            m_minRotationSpeed = br.ReadSingle();
            m_maxRotationSpeed = br.ReadSingle();
            m_minRotationBlend = br.ReadSingle();
            m_maxRotationBlend = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_transformSetIndex);
            bw.WriteUInt32(m_transformIndex);
            bw.WriteBoolean(m_transferTranslationMotion);
            bw.WriteByte(0);
            bw.WriteUInt16(0);
            bw.WriteSingle(m_minTranslationSpeed);
            bw.WriteSingle(m_maxTranslationSpeed);
            bw.WriteSingle(m_minTranslationBlend);
            bw.WriteSingle(m_maxTranslationBlend);
            bw.WriteBoolean(m_transferRotationMotion);
            bw.WriteByte(0);
            bw.WriteUInt16(0);
            bw.WriteSingle(m_minRotationSpeed);
            bw.WriteSingle(m_maxRotationSpeed);
            bw.WriteSingle(m_minRotationBlend);
            bw.WriteSingle(m_maxRotationBlend);
        }
    }
}