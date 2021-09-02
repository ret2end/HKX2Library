namespace HKX2
{
    public class hkMultipleVertexBufferElementInfo : IHavokObject
    {
        public byte m_elementIndex;

        public byte m_vertexBufferIndex;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_vertexBufferIndex = br.ReadByte();
            m_elementIndex = br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteByte(m_vertexBufferIndex);
            bw.WriteByte(m_elementIndex);
        }
    }
}