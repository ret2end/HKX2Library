namespace HKX2
{
    public class hkaiSimpleObstacleGenerator : hkaiObstacleGenerator
    {
        public hkAabb m_localAabb;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_localAabb = new hkAabb();
            m_localAabb.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_localAabb.Write(s, bw);
        }
    }
}