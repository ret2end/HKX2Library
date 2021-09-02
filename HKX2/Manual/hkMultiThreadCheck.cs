namespace HKX2
{
    public class hkMultiThreadCheck : IHavokObject
    {
        public virtual uint Signature => 0x0;


        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            br.ReadUInt32(); // threadId
            br.ReadInt32(); // stackTraceId
            br.ReadUInt16(); // markCount
            br.ReadUInt16(); // markBitStack
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(0); // threadId
            bw.WriteInt32(0); // stackTraceId
            bw.WriteUInt16(0); // markCount
            bw.WriteUInt16(0); // markBitStack
        }
    }
}