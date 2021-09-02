namespace HKX2
{
    public enum MaxConstraintSetSize
    {
        MAX_CONSTRAINT_SET_SIZE = 128
    }

    public class hclConstraintSet : hkReferencedObject
    {
        public string m_name;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            br.ReadUInt32(); // type

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            bw.WriteUInt32(0); // type

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}