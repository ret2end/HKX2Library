namespace HKX2
{
    public class hkxEnumItem : IHavokObject
    {
        public string m_name;

        public int m_value;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_value = br.ReadInt32();
            br.ReadUInt32();
            m_name = des.ReadStringPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_value);
            bw.WriteUInt32(0);
            s.WriteStringPointer(bw, m_name);
        }
    }
}