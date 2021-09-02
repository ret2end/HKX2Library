namespace HKX2
{
    public class hkaiNavMeshEdge : IHavokObject
    {
        public int m_a;
        public int m_b;
        public EdgeFlagBits m_flags;
        public uint m_oppositeEdge;
        public uint m_oppositeFace;
        public short m_userEdgeCost;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_a = br.ReadInt32();
            m_b = br.ReadInt32();
            m_oppositeEdge = br.ReadUInt32();
            m_oppositeFace = br.ReadUInt32();
            m_flags = (EdgeFlagBits) br.ReadByte();
            br.ReadByte(); // paddingByte
            m_userEdgeCost = br.ReadInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_a);
            bw.WriteInt32(m_b);
            bw.WriteUInt32(m_oppositeEdge);
            bw.WriteUInt32(m_oppositeFace);
            bw.WriteByte((byte) m_flags);
            bw.WriteByte(0); // paddingByte
            bw.WriteInt16(m_userEdgeCost);
        }
    }
}