namespace HKX2
{
    public class hkcdStaticTreeCodec3Axis4 : hkcdStaticTreeCodec3Axis
    {
        public byte m_data;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_data = br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteByte(m_data);
        }
    }
}