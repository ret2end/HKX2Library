namespace HKX2
{
    public enum EdgeSelectionType
    {
        EDGE_SELECTION_ALL = 0,
        EDGE_SELECTION_NONE = 1,
        EDGE_SELECTION_CHANNEL = 2,
        EDGE_SELECTION_INVERSE_CHANNEL = 3
    }

    public class hclEdgeSelectionInput : IHavokObject
    {
        public string m_channelName;

        public EdgeSelectionType m_type;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_type = (EdgeSelectionType) br.ReadUInt32();
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