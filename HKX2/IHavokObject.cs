namespace HKX2
{
    public interface IHavokObject
    {
        public uint Signature { get; }

        public void Read(PackFileDeserializer des, BinaryReaderEx br);

        public void Write(PackFileSerializer s, BinaryWriterEx bw);
    }
}