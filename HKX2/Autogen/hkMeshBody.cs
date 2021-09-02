namespace HKX2
{
    public enum PickDataIdentifier
    {
        PICK_RIGID_BODY_WITH_BREAKABLE_BODY = 1,
        PICK_USER = 4096
    }

    public class hkMeshBody : hkReferencedObject
    {
        public override uint Signature => 0;


        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
        }
    }
}