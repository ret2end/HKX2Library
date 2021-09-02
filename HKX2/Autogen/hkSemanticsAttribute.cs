namespace HKX2
{
    public enum Semantics
    {
        UNKNOWN = 0,
        DISTANCE = 1,
        ANGLE = 2,
        NORMAL = 3,
        POSITION = 4,
        COSINE_ANGLE = 5
    }

    public class hkSemanticsAttribute : IHavokObject
    {
        public Semantics m_type;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_type = (Semantics) br.ReadSByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSByte((sbyte) m_type);
        }
    }
}