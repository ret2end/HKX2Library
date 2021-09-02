namespace HKX2
{
    public class hkpConstraintChainInstanceAction : hkpAction
    {
        public hkpConstraintChainInstance m_constraintInstance;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_constraintInstance = des.ReadClassPointer<hkpConstraintChainInstance>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_constraintInstance);
        }
    }
}