namespace HKX2
{
    public class hkpWrappedConstraintData : hkpConstraintData
    {
        public hkpConstraintData m_constraintData;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_constraintData = des.ReadClassPointer<hkpConstraintData>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_constraintData);
        }
    }
}