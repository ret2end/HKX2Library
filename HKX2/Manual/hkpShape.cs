namespace HKX2
{
    public class hkpShape : hkpShapeBase
    {
        public ulong m_userData;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_userData = br.ReadUSize();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUSize(m_userData);
        }
    }
}