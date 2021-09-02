namespace HKX2
{
    public class hkaiDynamicNavVolumeMediator : hkaiNavVolumeMediator
    {
        public hkcdDynamicAabbTree m_aabbTree;

        public hkaiStreamingCollection m_collection;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_collection = des.ReadClassPointer<hkaiStreamingCollection>(br);
            m_aabbTree = des.ReadClassPointer<hkcdDynamicAabbTree>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_collection);
            s.WriteClassPointer(bw, m_aabbTree);
        }
    }
}