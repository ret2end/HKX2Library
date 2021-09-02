namespace HKX2
{
    public class hkaAnnotationTrackAnnotation : IHavokObject
    {
        public string m_text;

        public float m_time;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_time = br.ReadSingle();
            m_text = des.ReadStringPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_time);
            s.WriteStringPointer(bw, m_text);
        }
    }
}