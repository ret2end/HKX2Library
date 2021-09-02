namespace HKX2
{
    public class hkxNodeAnnotationData : IHavokObject
    {
        public string m_description;

        public float m_time;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_time = br.ReadSingle();
            br.ReadUInt32();
            m_description = des.ReadStringPointer(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_time);
            bw.WriteUInt32(0);
            s.WriteStringPointer(bw, m_description);
        }
    }
}