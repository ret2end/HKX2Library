namespace HKX2
{
    public class hkxSparselyAnimatedEnum : hkxSparselyAnimatedInt
    {
        public hkxEnum m_enum;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_enum = des.ReadClassPointer<hkxEnum>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_enum);
        }
    }
}