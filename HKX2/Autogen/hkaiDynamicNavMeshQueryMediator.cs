namespace HKX2
{
    public class hkaiDynamicNavMeshQueryMediator : hkaiNavMeshQueryMediator
    {
        public hkcdDynamicAabbTree m_aabbTree;

        public hkaiStreamingCollection m_collection;
        public float m_cutAabbTolerance;
        public hkaiNavMeshCutter m_cutter;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_collection = des.ReadClassPointer<hkaiStreamingCollection>(br);
            m_aabbTree = des.ReadClassPointer<hkcdDynamicAabbTree>(br);
            m_cutter = des.ReadClassPointer<hkaiNavMeshCutter>(br);
            m_cutAabbTolerance = br.ReadSingle();
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_collection);
            s.WriteClassPointer(bw, m_aabbTree);
            s.WriteClassPointer(bw, m_cutter);
            bw.WriteSingle(m_cutAabbTolerance);
            bw.WriteUInt32(0);
        }
    }
}