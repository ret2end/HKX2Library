namespace HKX2
{
    public class hkaiEdgeGeometryEdge : IHavokObject
    {
        public uint m_a;
        public uint m_b;
        public uint m_data;
        public uint m_face;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_a = br.ReadUInt32();
            m_b = br.ReadUInt32();
            m_face = br.ReadUInt32();
            m_data = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_a);
            bw.WriteUInt32(m_b);
            bw.WriteUInt32(m_face);
            bw.WriteUInt32(m_data);
        }
    }
}