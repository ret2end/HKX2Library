namespace HKX2
{
    public enum MotorType
    {
        TYPE_INVALID = 0,
        TYPE_POSITION = 1,
        TYPE_VELOCITY = 2,
        TYPE_SPRING_DAMPER = 3,
        TYPE_CALLBACK = 4,
        TYPE_MAX = 5
    }

    public class hkpConstraintMotor : hkReferencedObject
    {
        public MotorType m_type;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);

            if (des._header.PointerSize == 8) br.Position -= 4;

            m_type = (MotorType) br.ReadSByte();
            br.ReadByte();
            br.ReadUInt16();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);

            if (s._header.PointerSize == 8) bw.Position -= 4;

            bw.WriteSByte((sbyte) m_type);
            bw.WriteByte(0);
            bw.WriteUInt16(0);
        }
    }
}