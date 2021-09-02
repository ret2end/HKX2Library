namespace HKX2
{
    public class hkp2dAngConstraintAtom : hkpConstraintAtom
    {
        public byte m_freeRotationAxis;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_freeRotationAxis = br.ReadByte();
            br.ReadByte();
            br.ReadBytes(12); // padding
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteByte(m_freeRotationAxis);
            bw.WriteByte(0);
            bw.WriteBytes(new byte[12]);
        }
    }
}