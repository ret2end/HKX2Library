namespace HKX2
{
    public class hkcdDynamicTreeCodecRawunsignedlong : IHavokObject
    {
        public hkAabb m_aabb;
        public ulong m_children_0;
        public ulong m_children_1;
        public ulong m_parent;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_aabb = new hkAabb();
            m_aabb.Read(des, br);
            m_parent = br.ReadUInt64();
            m_children_0 = br.ReadUInt64();
            m_children_1 = br.ReadUInt64();
            br.ReadUInt64();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_aabb.Write(s, bw);
            bw.WriteUInt64(m_parent);
            bw.WriteUInt64(m_children_0);
            bw.WriteUInt64(m_children_1);
            bw.WriteUInt64(0);
        }
    }
}