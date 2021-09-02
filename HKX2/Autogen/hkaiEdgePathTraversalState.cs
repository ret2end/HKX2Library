namespace HKX2
{
    public class hkaiEdgePathTraversalState : IHavokObject
    {
        public int m_faceEdge;
        public int m_highestUserEdgeCrossed;
        public int m_trailingEdge;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_faceEdge = br.ReadInt32();
            m_trailingEdge = br.ReadInt32();
            m_highestUserEdgeCrossed = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_faceEdge);
            bw.WriteInt32(m_trailingEdge);
            bw.WriteInt32(m_highestUserEdgeCrossed);
        }
    }
}