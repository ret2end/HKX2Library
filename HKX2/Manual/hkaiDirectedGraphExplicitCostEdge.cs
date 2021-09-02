namespace HKX2
{
    public class hkaiDirectedGraphExplicitCostEdge : IHavokObject
    {
        public short m_cost;
        public EdgeBits m_flags;
        public uint m_target;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_cost = br.ReadInt16();
            m_flags = (EdgeBits) br.ReadUInt16();
            m_target = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt16(m_cost);
            bw.WriteUInt16((ushort) m_flags);
            bw.WriteUInt32(m_target);
        }
    }
}