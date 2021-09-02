namespace HKX2
{
    public class hkRootLevelContainerNamedVariant : IHavokObject
    {
        public string m_className;

        public string m_name;
        public hkReferencedObject m_variant;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_name = des.ReadStringPointer(br);
            m_className = des.ReadStringPointer(br);
            m_variant = des.ReadClassPointer<hkReferencedObject>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_name);
            s.WriteStringPointer(bw, m_className);
            s.WriteClassPointer(bw, m_variant);
        }
    }
}