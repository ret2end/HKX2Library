namespace HKX2
{
    public class hclUpdateSomeVertexFramesOperatorTriangle : IHavokObject
    {
        public ushort m_indices_0;
        public ushort m_indices_1;
        public ushort m_indices_2;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_indices_0 = br.ReadUInt16();
            m_indices_1 = br.ReadUInt16();
            m_indices_2 = br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt16(m_indices_0);
            bw.WriteUInt16(m_indices_1);
            bw.WriteUInt16(m_indices_2);
        }
    }
}