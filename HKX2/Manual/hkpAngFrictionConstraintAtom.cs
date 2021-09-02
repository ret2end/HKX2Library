namespace HKX2
{
    public class hkpAngFrictionConstraintAtom : hkpConstraintAtom
    {
        public byte m_firstFrictionAxis;

        public byte m_isEnabled;
        public float m_maxFrictionTorque;
        public byte m_numFrictionAxes;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_isEnabled = br.ReadByte();
            m_firstFrictionAxis = br.ReadByte();
            m_numFrictionAxes = br.ReadByte();
            br.ReadByte();
            br.ReadUInt16();
            m_maxFrictionTorque = br.ReadSingle();
            br.ReadBytes(4); // padding
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteByte(m_isEnabled);
            bw.WriteByte(m_firstFrictionAxis);
            bw.WriteByte(m_numFrictionAxes);
            bw.WriteByte(0);
            bw.WriteUInt16(0);
            bw.WriteSingle(m_maxFrictionTorque);
            bw.WriteBytes(new byte[4]); // padding
        }
    }
}