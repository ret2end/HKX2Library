namespace HKX2
{
    public class hkPostFinishAttribute : IHavokObject
    {
        public virtual uint Signature => 0;


        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            br.ReadUInt64();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt64(0);
        }
    }
}