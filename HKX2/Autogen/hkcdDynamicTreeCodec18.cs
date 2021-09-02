namespace HKX2
{
    public class hkcdDynamicTreeCodec18 : IHavokObject
    {
        public hkAabbHalf m_aabb;
        public ushort m_parent;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_aabb = new hkAabbHalf();
            m_aabb.Read(des, br);
            m_parent = br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_aabb.Write(s, bw);
            bw.WriteUInt16(m_parent);
        }
    }
}