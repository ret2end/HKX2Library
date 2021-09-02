namespace HKX2
{
    public class hkDescriptionAttribute : IHavokObject
    {
        public string m_string;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_string = des.ReadStringPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_string);
        }
    }
}