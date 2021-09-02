namespace HKX2
{
    public class hkMonitorStreamColorTableColorPair : IHavokObject
    {
        public uint m_color;

        public string m_colorName;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_colorName = des.ReadStringPointer(br);
            m_color = br.ReadUInt32();
            br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_colorName);
            bw.WriteUInt32(m_color);
            bw.WriteUInt32(0);
        }
    }
}