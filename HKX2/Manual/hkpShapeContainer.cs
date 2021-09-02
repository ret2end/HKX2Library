namespace HKX2
{
    public class hkpShapeContainer : IHavokObject
    {
        public virtual uint Signature => 0x0;


        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            br.ReadUSize();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUSize(0);
        }
    }
}