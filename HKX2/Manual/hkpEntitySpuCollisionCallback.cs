namespace HKX2
{
    public enum SpuCollisionCallbackEventFilter
    {
        SPU_SEND_NONE = 0,
        SPU_SEND_CONTACT_POINT_ADDED = 1,
        SPU_SEND_CONTACT_POINT_PROCESS = 2,
        SPU_SEND_CONTACT_POINT_ADDED_OR_PROCESS = 3,
        SPU_SEND_CONTACT_POINT_REMOVED = 4
    }

    public class hkpEntitySpuCollisionCallback : IHavokObject
    {
        public SpuCollisionCallbackEventFilter m_eventFilter;
        public byte m_userFilter;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            des.ReadEmptyPointer(br); // util
            br.ReadUInt16(); // capacity
            m_eventFilter = (SpuCollisionCallbackEventFilter) br.ReadByte();
            m_userFilter = br.ReadByte();

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVoidPointer(bw); // util
            bw.WriteUInt16(0); // capacity
            bw.WriteByte((byte) m_eventFilter);
            bw.WriteByte(m_userFilter);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}