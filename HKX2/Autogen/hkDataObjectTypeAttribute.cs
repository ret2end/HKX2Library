namespace HKX2
{
    public class hkDataObjectTypeAttribute : IHavokObject
    {
        public string m_typeName;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_typeName = des.ReadStringPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_typeName);
        }
    }
}