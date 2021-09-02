namespace HKX2
{
    public class hkaAngularReferenceFrame : hkaParameterizedReferenceFrame
    {
        public float m_radius;

        public float m_topAngle;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_topAngle = br.ReadSingle();
            m_radius = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_topAngle);
            bw.WriteSingle(m_radius);
        }
    }
}