namespace HKX2
{
    public class hkcdPlanarSolidNode : IHavokObject
    {
        public uint m_aabbId;
        public uint m_data;
        public ushort m_flags;
        public uint m_left;
        public ulong m_material;
        public uint m_nextFreeNodeId;

        public uint m_parent;
        public uint m_planeId;
        public uint m_right;
        public ushort m_type;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_parent = br.ReadUInt32();
            m_left = br.ReadUInt32();
            m_right = br.ReadUInt32();
            m_nextFreeNodeId = br.ReadUInt32();
            m_planeId = br.ReadUInt32();
            m_aabbId = br.ReadUInt32();
            m_material = br.ReadUInt64();
            m_data = br.ReadUInt32();
            m_type = br.ReadUInt16();
            m_flags = br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_parent);
            bw.WriteUInt32(m_left);
            bw.WriteUInt32(m_right);
            bw.WriteUInt32(m_nextFreeNodeId);
            bw.WriteUInt32(m_planeId);
            bw.WriteUInt32(m_aabbId);
            bw.WriteUInt64(m_material);
            bw.WriteUInt32(m_data);
            bw.WriteUInt16(m_type);
            bw.WriteUInt16(m_flags);
        }
    }
}