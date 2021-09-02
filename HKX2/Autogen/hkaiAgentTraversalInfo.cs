namespace HKX2
{
    public class hkaiAgentTraversalInfo : IHavokObject
    {
        public float m_diameter;
        public uint m_filterInfo;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_diameter = br.ReadSingle();
            m_filterInfo = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_diameter);
            bw.WriteUInt32(m_filterInfo);
        }
    }
}