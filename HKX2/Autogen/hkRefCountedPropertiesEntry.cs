namespace HKX2
{
    public class hkRefCountedPropertiesEntry : IHavokObject
    {
        public ushort m_flags;
        public ushort m_key;

        public hkReferencedObject m_object;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_object = des.ReadClassPointer<hkReferencedObject>(br);
            m_key = br.ReadUInt16();
            m_flags = br.ReadUInt16();
            br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_object);
            bw.WriteUInt16(m_key);
            bw.WriteUInt16(m_flags);
            bw.WriteUInt32(0);
        }
    }
}