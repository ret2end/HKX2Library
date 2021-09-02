namespace HKX2
{
    public class hkpStiffSpringConstraintAtom : hkpConstraintAtom
    {
        public float m_length;
        public float m_maxLength;
        public float m_springConstant;
        public float m_springDamping;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            br.ReadUInt32();
            br.ReadUInt16();
            m_length = br.ReadSingle();
            m_maxLength = br.ReadSingle();
            m_springConstant = br.ReadSingle();
            m_springDamping = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteSingle(m_length);
            bw.WriteSingle(m_maxLength);
            bw.WriteSingle(m_springConstant);
            bw.WriteSingle(m_springDamping);
        }
    }
}