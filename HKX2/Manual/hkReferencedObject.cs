namespace HKX2
{
    public class hkReferencedObject : hkBaseObject
    {
        public override uint Signature => 0x0;


        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt32(); // memSizeAndRefCount

            // For some reason, the class is padded even when
            // the padded space is used in some derived classes.
            // Only seems to be the case with 64bit files.
            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt32(0); // memSizeAndRefCount

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}