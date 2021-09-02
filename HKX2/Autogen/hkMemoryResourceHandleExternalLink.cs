namespace HKX2
{
    public class hkMemoryResourceHandleExternalLink : IHavokObject
    {
        public string m_externalId;

        public string m_memberName;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_memberName = des.ReadStringPointer(br);
            m_externalId = des.ReadStringPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_memberName);
            s.WriteStringPointer(bw, m_externalId);
        }
    }
}