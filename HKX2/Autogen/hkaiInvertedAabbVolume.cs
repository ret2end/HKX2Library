namespace HKX2
{
    public class hkaiInvertedAabbVolume : hkaiVolume
    {
        public hkAabb m_aabb;
        public hkGeometry m_geometry;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_aabb = new hkAabb();
            m_aabb.Read(des, br);
            m_geometry = new hkGeometry();
            m_geometry.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_aabb.Write(s, bw);
            m_geometry.Write(s, bw);
        }
    }
}