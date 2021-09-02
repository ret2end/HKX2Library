namespace HKX2
{
    public class hkpShapePhantom : hkpPhantom
    {
        public hkMotionState m_motionState;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            m_motionState = new hkMotionState();
            m_motionState.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            m_motionState.Write(s, bw);
        }
    }
}