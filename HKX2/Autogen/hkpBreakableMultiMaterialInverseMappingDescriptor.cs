namespace HKX2
{
    public class hkpBreakableMultiMaterialInverseMappingDescriptor : IHavokObject
    {
        public ushort m_numKeys;

        public ushort m_offset;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_offset = br.ReadUInt16();
            m_numKeys = br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt16(m_offset);
            bw.WriteUInt16(m_numKeys);
        }
    }
}