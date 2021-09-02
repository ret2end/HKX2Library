namespace HKX2
{
    public class hkpBinaryAction : hkpAction
    {
        public hkpEntity m_entityA;
        public hkpEntity m_entityB;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_entityA = des.ReadClassPointer<hkpEntity>(br);
            m_entityB = des.ReadClassPointer<hkpEntity>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_entityA);
            s.WriteClassPointer(bw, m_entityB);
        }
    }
}