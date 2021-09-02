namespace HKX2
{
    public class hclGatherSomeVerticesOperatorVertexPair : IHavokObject
    {
        public ushort m_indexInput;
        public ushort m_indexOutput;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_indexInput = br.ReadUInt16();
            m_indexOutput = br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt16(m_indexInput);
            bw.WriteUInt16(m_indexOutput);
        }
    }
}