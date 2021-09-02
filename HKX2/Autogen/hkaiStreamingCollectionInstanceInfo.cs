namespace HKX2
{
    public class hkaiStreamingCollectionInstanceInfo : IHavokObject
    {
        public hkaiDirectedGraphInstance m_clusterGraphInstance;

        public hkaiNavMeshInstance m_instancePtr;
        public hkaiNavMeshQueryMediator m_mediator;
        public uint m_treeNode;
        public hkaiNavVolumeInstance m_volumeInstancePtr;
        public hkaiNavVolumeMediator m_volumeMediator;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_instancePtr = des.ReadClassPointer<hkaiNavMeshInstance>(br);
            m_volumeInstancePtr = des.ReadClassPointer<hkaiNavVolumeInstance>(br);
            m_clusterGraphInstance = des.ReadClassPointer<hkaiDirectedGraphInstance>(br);
            m_mediator = des.ReadClassPointer<hkaiNavMeshQueryMediator>(br);
            m_volumeMediator = des.ReadClassPointer<hkaiNavVolumeMediator>(br);
            m_treeNode = br.ReadUInt32();
            br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_instancePtr);
            s.WriteClassPointer(bw, m_volumeInstancePtr);
            s.WriteClassPointer(bw, m_clusterGraphInstance);
            s.WriteClassPointer(bw, m_mediator);
            s.WriteClassPointer(bw, m_volumeMediator);
            bw.WriteUInt32(m_treeNode);
            bw.WriteUInt32(0);
        }
    }
}