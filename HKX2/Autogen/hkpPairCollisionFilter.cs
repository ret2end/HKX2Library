namespace HKX2
{
    public class hkpPairCollisionFilter : hkpCollisionFilter
    {
        public hkpCollisionFilter m_childFilter;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            br.ReadUInt64();
            m_childFilter = des.ReadClassPointer<hkpCollisionFilter>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            s.WriteClassPointer(bw, m_childFilter);
        }
    }
}