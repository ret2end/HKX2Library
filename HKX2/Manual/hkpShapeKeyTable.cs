namespace HKX2
{
    public class hkpShapeKeyTable : IHavokObject
    {
        public hkpShapeKeyTableBlock m_lists;
        public uint m_occupancyBitField;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_lists = des.ReadClassPointer<hkpShapeKeyTableBlock>(br);
            m_occupancyBitField = br.ReadUInt32();

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_lists);
            bw.WriteUInt32(m_occupancyBitField);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}