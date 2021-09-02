namespace HKX2
{
    public class hkpBreakableBodyController : hkReferencedObject
    {
        public float m_breakingImpulse;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_breakingImpulse = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_breakingImpulse);
        }
    }
}