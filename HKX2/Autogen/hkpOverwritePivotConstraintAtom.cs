namespace HKX2
{
    public class hkpOverwritePivotConstraintAtom : hkpConstraintAtom
    {
        public byte m_copyToPivotBFromPivotA;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_copyToPivotBFromPivotA = br.ReadByte();
            br.ReadUInt64();
            br.ReadUInt32();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteByte(m_copyToPivotBFromPivotA);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            bw.WriteByte(0);
        }
    }
}