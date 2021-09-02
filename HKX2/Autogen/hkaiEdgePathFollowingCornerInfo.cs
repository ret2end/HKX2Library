namespace HKX2
{
    public class hkaiEdgePathFollowingCornerInfo : IHavokObject
    {
        public ushort m_data;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_data = br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt16(m_data);
        }
    }
}