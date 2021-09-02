namespace HKX2
{
    public class hkaReferencePoseAnimation : hkaAnimation
    {
        public hkaSkeleton m_skeleton;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_skeleton = des.ReadClassPointer<hkaSkeleton>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_skeleton);
        }
    }
}