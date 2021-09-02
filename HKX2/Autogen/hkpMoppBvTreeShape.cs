namespace HKX2
{
    public class hkpMoppBvTreeShape : hkMoppBvTreeShapeBase
    {
        public hkpSingleShapeContainer m_child;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_child = new hkpSingleShapeContainer();
            m_child.Read(des, br);
            br.ReadUInt64();
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_child.Write(s, bw);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
        }
    }
}