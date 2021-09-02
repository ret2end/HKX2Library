namespace HKX2
{
    public class hkaiAdaptiveRanger : IHavokObject
    {
        public float m_curRange;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_curRange = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_curRange);
        }
    }
}