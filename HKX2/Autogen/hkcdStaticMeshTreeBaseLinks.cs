namespace HKX2
{
    public class hkcdStaticMeshTreeBaseLinks : IHavokObject
    {
        public hkcdStaticMeshTreeBaseEdge m_links_0;
        public hkcdStaticMeshTreeBaseEdge m_links_1;
        public hkcdStaticMeshTreeBaseEdge m_links_2;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_links_0 = new hkcdStaticMeshTreeBaseEdge();
            m_links_0.Read(des, br);
            m_links_1 = new hkcdStaticMeshTreeBaseEdge();
            m_links_1.Read(des, br);
            m_links_2 = new hkcdStaticMeshTreeBaseEdge();
            m_links_2.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_links_0.Write(s, bw);
            m_links_1.Write(s, bw);
            m_links_2.Write(s, bw);
        }
    }
}