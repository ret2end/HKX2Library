namespace HKX2
{
    public enum ArrayType
    {
        NONE = 0,
        POINTSOUP = 1,
        ENTITIES = 2
    }

    public class hkArrayTypeAttribute : IHavokObject
    {
        public ArrayType m_type;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_type = (ArrayType) br.ReadSByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSByte((sbyte) m_type);
        }
    }
}