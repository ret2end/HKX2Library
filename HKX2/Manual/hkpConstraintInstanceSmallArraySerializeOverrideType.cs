namespace HKX2
{
    public class hkpConstraintInstanceSmallArraySerializeOverrideType : IHavokObject
    {
        public ushort m_capacityAndFlags;

        public ushort m_size;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            des.ReadEmptyPointer(br);
            m_size = br.ReadUInt16();
            m_capacityAndFlags = br.ReadUInt16();

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVoidPointer(bw);
            bw.WriteUInt16(m_size);
            bw.WriteUInt16(m_capacityAndFlags);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}