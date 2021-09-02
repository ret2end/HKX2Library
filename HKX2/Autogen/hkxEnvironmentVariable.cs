namespace HKX2
{
    public class hkxEnvironmentVariable : IHavokObject
    {
        public string m_name;
        public string m_value;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_name = des.ReadStringPointer(br);
            m_value = des.ReadStringPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_name);
            s.WriteStringPointer(bw, m_value);
        }
    }
}