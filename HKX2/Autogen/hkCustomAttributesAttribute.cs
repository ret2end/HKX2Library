namespace HKX2
{
    public class hkCustomAttributesAttribute : IHavokObject
    {
        public string m_name;
        public ulong m_value;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_name = des.ReadStringPointer(br);
            // Read TYPE_VARIANT
            br.ReadUInt64();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_name);
            // Read TYPE_VARIANT
            bw.WriteUInt64(0);
        }
    }
}