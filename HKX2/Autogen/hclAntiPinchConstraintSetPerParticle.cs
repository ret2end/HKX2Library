namespace HKX2
{
    public class hclAntiPinchConstraintSetPerParticle : IHavokObject
    {
        public ushort m_particleIndex;
        public ushort m_referenceVertex;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_particleIndex = br.ReadUInt16();
            m_referenceVertex = br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt16(m_particleIndex);
            bw.WriteUInt16(m_referenceVertex);
        }
    }
}