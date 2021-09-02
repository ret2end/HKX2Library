namespace HKX2
{
    public class hkaiStaticTreeNavMeshQueryMediator : hkaiNavMeshQueryMediator
    {
        public hkaiNavMesh m_navMesh;

        public hkcdStaticAabbTree m_tree;
        public override uint Signature => 0x433A1E61;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_tree = des.ReadClassPointer<hkcdStaticAabbTree>(br);
            m_navMesh = des.ReadClassPointer<hkaiNavMesh>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_tree);
            s.WriteClassPointer(bw, m_navMesh);
        }
    }
}