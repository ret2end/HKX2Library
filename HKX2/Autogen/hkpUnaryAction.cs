namespace HKX2
{
    public class hkpUnaryAction : hkpAction
    {
        public hkpEntity m_entity;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_entity = des.ReadClassPointer<hkpEntity>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_entity);
        }
    }
}