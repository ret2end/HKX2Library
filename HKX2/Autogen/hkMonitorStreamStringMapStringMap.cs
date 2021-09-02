namespace HKX2
{
    public class hkMonitorStreamStringMapStringMap : IHavokObject
    {
        public ulong m_id;
        public string m_string;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_id = br.ReadUInt64();
            m_string = des.ReadStringPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt64(m_id);
            s.WriteStringPointer(bw, m_string);
        }
    }
}