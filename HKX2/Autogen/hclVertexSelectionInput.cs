namespace HKX2
{
    public enum VertexSelectionType
    {
        VERTEX_SELECTION_ALL = 0,
        VERTEX_SELECTION_NONE = 1,
        VERTEX_SELECTION_CHANNEL = 2,
        VERTEX_SELECTION_INVERSE_CHANNEL = 3
    }

    public class hclVertexSelectionInput : IHavokObject
    {
        public string m_channelName;

        public VertexSelectionType m_type;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_type = (VertexSelectionType) br.ReadUInt32();
            br.ReadUInt32();
            m_channelName = des.ReadStringPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32((uint) m_type);
            bw.WriteUInt32(0);
            s.WriteStringPointer(bw, m_channelName);
        }
    }
}