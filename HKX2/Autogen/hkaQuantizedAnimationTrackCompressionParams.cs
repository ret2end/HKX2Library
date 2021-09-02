namespace HKX2
{
    public class hkaQuantizedAnimationTrackCompressionParams : IHavokObject
    {
        public float m_floatingTolerance;

        public float m_rotationTolerance;
        public float m_scaleTolerance;
        public float m_translationTolerance;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_rotationTolerance = br.ReadSingle();
            m_translationTolerance = br.ReadSingle();
            m_scaleTolerance = br.ReadSingle();
            m_floatingTolerance = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_rotationTolerance);
            bw.WriteSingle(m_translationTolerance);
            bw.WriteSingle(m_scaleTolerance);
            bw.WriteSingle(m_floatingTolerance);
        }
    }
}