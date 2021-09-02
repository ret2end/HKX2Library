namespace HKX2
{
    public enum Link
    {
        NONE = 0,
        DIRECT_LINK = 1,
        CHILD = 2,
        MESH = 3,
        PARENT_NAME = 4,
        IMGSELECT = 5,
        NODE_UUID = 6
    }

    public class hkLinkAttribute : IHavokObject
    {
        public Link m_type;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_type = (Link) br.ReadSByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSByte((sbyte) m_type);
        }
    }
}