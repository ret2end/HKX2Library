namespace HKX2
{
    public class hclToolNamedObjectReference : IHavokObject
    {
        public uint m_hash;
        public string m_objectName;

        public string m_pluginName;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_pluginName = des.ReadStringPointer(br);
            m_objectName = des.ReadStringPointer(br);
            m_hash = br.ReadUInt32();
            br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_pluginName);
            s.WriteStringPointer(bw, m_objectName);
            bw.WriteUInt32(m_hash);
            bw.WriteUInt32(0);
        }
    }
}