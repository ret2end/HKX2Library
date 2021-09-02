namespace HKX2
{
    public class hkpDefaultWorldMemoryWatchDog : hkWorldMemoryAvailableWatchDog
    {
        public int m_freeHeapMemoryRequested;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_freeHeapMemoryRequested = br.ReadInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteInt32(m_freeHeapMemoryRequested);
        }
    }
}