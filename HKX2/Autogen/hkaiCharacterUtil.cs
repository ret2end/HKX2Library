namespace HKX2
{
    public enum CallbackType
    {
        CALLBACK_PATH_SUCCEEDED = 0,
        CALLBACK_PATH_FAILED_INVALID_START = 1,
        CALLBACK_PATH_FAILED_INVALID_GOAL = 2,
        CALLBACK_PATH_FAILED_INVALID_UNREACHABLE = 3,
        CALLBACK_PATH_NOT_READY = 4
    }

    public class hkaiCharacterUtil : IHavokObject
    {
        public virtual uint Signature => 0;


        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteByte(0);
        }
    }
}