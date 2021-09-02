namespace HKX2
{
    public class hclStorageSetupMeshTriangleChannel : IHavokObject
    {
        public string m_name;
        public TriangleChannelType m_type;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_name = des.ReadStringPointer(br);
            m_type = (TriangleChannelType) br.ReadUInt32();
            br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_name);
            bw.WriteUInt32((uint) m_type);
            bw.WriteUInt32(0);
        }
    }
}