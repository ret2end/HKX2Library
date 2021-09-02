namespace HKX2
{
    public class hkpAngConstraintAtom : hkpConstraintAtom
    {
        public byte m_constrainedAxes_0;
        public byte m_constrainedAxes_1;
        public byte m_constrainedAxes_2;
        public byte m_numConstrainedAxes;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_constrainedAxes_0 = br.ReadByte();
            m_constrainedAxes_1 = br.ReadByte();
            m_constrainedAxes_2 = br.ReadByte();
            m_numConstrainedAxes = br.ReadByte();
            br.ReadUInt64();
            br.ReadUInt16();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteByte(m_constrainedAxes_0);
            bw.WriteByte(m_constrainedAxes_1);
            bw.WriteByte(m_constrainedAxes_2);
            bw.WriteByte(m_numConstrainedAxes);
            bw.WriteUInt64(0);
            bw.WriteUInt16(0);
        }
    }
}