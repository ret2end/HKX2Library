namespace HKX2
{
    public enum AccessFlags
    {
        ACCESS_INDICES = 1,
        ACCESS_VERTEX_BUFFER = 2
    }

    public class hkMeshShape : hkReferencedObject
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