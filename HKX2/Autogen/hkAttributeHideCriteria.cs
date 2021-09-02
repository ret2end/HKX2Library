namespace HKX2
{
    public enum Types
    {
        NONE = 0,
        MODELER_IS_MAX = 1,
        MODELER_IS_MAYA = 2,
        UI_SCHEME_IS_DESTRUCTION = 4,
        UI_SCHEME_IS_DESTRUCTION_2012 = 8
    }

    public class hkAttributeHideCriteria : IHavokObject
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