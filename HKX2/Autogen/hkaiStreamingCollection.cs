using System.Collections.Generic;

namespace HKX2
{
    public class hkaiStreamingCollection : hkReferencedObject
    {
        public hkaiNavMeshClearanceCacheManager m_clearanceCacheManager;
        public List<hkaiStreamingCollectionInstanceInfo> m_instances;

        public bool m_isTemporary;
        public hkcdDynamicAabbTree m_tree;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_isTemporary = br.ReadBoolean();
            br.ReadUInt16();
            br.ReadByte();
            m_tree = des.ReadClassPointer<hkcdDynamicAabbTree>(br);
            m_instances = des.ReadClassArray<hkaiStreamingCollectionInstanceInfo>(br);
            m_clearanceCacheManager = des.ReadClassPointer<hkaiNavMeshClearanceCacheManager>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteBoolean(m_isTemporary);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            s.WriteClassPointer(bw, m_tree);
            s.WriteClassArray(bw, m_instances);
            s.WriteClassPointer(bw, m_clearanceCacheManager);
        }
    }
}