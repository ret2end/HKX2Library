namespace HKX2
{
    public class hclBlendSomeVerticesOperatorBlendEntry : IHavokObject
    {
        public float m_blendWeight;

        public ushort m_vertexIndex;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_vertexIndex = br.ReadUInt16();
            br.ReadUInt16();
            m_blendWeight = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt16(m_vertexIndex);
            bw.WriteUInt16(0);
            bw.WriteSingle(m_blendWeight);
        }
    }
}