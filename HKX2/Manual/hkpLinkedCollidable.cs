namespace HKX2
{
    public class hkpLinkedCollidable : hkpCollidable
    {
        public override uint Signature => 0x0;


        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            des.ReadEmptyArray(br); // collisionEntries
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVoidArray(bw); // collisionEntries
        }
    }
}