namespace HKX2
{
    public class hkaiAabbTreeNavVolumeMediator : hkaiNavVolumeMediator
    {
        public hkaiNavVolume m_navVolume;
        public hkcdStaticAabbTree m_tree;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_navVolume = des.ReadClassPointer<hkaiNavVolume>(br);
            m_tree = des.ReadClassPointer<hkcdStaticAabbTree>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_navVolume);
            s.WriteClassPointer(bw, m_tree);
        }
    }
}