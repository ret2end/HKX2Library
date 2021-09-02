namespace HKX2
{
    public class hkaiStreamingSetGraphConnection : IHavokObject
    {
        public short m_edgeCost;
        public uint m_edgeData;

        public int m_nodeIndex;
        public int m_oppositeNodeIndex;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_nodeIndex = br.ReadInt32();
            m_oppositeNodeIndex = br.ReadInt32();
            m_edgeData = br.ReadUInt32();
            m_edgeCost = br.ReadInt16();
            br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_nodeIndex);
            bw.WriteInt32(m_oppositeNodeIndex);
            bw.WriteUInt32(m_edgeData);
            bw.WriteInt16(m_edgeCost);
            bw.WriteUInt16(0);
        }
    }
}