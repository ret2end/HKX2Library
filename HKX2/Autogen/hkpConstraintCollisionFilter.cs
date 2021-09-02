namespace HKX2
{
    public class hkpConstraintCollisionFilter : hkpPairCollisionFilter
    {
        public override uint Signature => 0;


        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
        }
    }
}