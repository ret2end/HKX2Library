namespace HKX2
{
    public class hkaiAvoidancePairPropertiesPairData : IHavokObject
    {
        public float m_cosViewAngle;

        public uint m_key;
        public float m_weight;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_key = br.ReadUInt32();
            m_weight = br.ReadSingle();
            m_cosViewAngle = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_key);
            bw.WriteSingle(m_weight);
            bw.WriteSingle(m_cosViewAngle);
        }
    }
}