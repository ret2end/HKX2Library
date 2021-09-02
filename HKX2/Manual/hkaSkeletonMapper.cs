namespace HKX2
{
    public enum ConstraintSource
    {
        NO_CONSTRAINTS = 0,
        REFERENCE_POSE = 1,
        CURRENT_POSE = 2
    }

    public class hkaSkeletonMapper : hkReferencedObject
    {
        public hkaSkeletonMapperData m_mapping;
        public override uint Signature => 0xACE9849C;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Pad(16);
            m_mapping = new hkaSkeletonMapperData();
            m_mapping.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Pad(16);
            m_mapping.Write(s, bw);
        }
    }
}