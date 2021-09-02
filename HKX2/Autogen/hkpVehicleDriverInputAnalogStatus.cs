namespace HKX2
{
    public class hkpVehicleDriverInputAnalogStatus : hkpVehicleDriverInputStatus
    {
        public bool m_handbrakeButtonPressed;

        public float m_positionX;
        public float m_positionY;
        public bool m_reverseButtonPressed;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_positionX = br.ReadSingle();
            m_positionY = br.ReadSingle();
            m_handbrakeButtonPressed = br.ReadBoolean();
            m_reverseButtonPressed = br.ReadBoolean();
            br.ReadUInt16();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_positionX);
            bw.WriteSingle(m_positionY);
            bw.WriteBoolean(m_handbrakeButtonPressed);
            bw.WriteBoolean(m_reverseButtonPressed);
            bw.WriteUInt16(0);
        }
    }
}