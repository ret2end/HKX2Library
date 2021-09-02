namespace HKX2
{
    public class hkpBroadPhaseHandle : IHavokObject
    {
        public virtual uint Signature => 0x0;


        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(0);
        }
    }
}