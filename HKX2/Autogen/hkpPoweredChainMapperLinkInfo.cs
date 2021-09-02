namespace HKX2
{
    public class hkpPoweredChainMapperLinkInfo : IHavokObject
    {
        public int m_firstTargetIdx;
        public hkpConstraintInstance m_limitConstraint;
        public int m_numTargets;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_firstTargetIdx = br.ReadInt32();
            m_numTargets = br.ReadInt32();
            m_limitConstraint = des.ReadClassPointer<hkpConstraintInstance>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_firstTargetIdx);
            bw.WriteInt32(m_numTargets);
            s.WriteClassPointer(bw, m_limitConstraint);
        }
    }
}