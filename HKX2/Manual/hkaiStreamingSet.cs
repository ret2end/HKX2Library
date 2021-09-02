using System.Collections.Generic;

namespace HKX2
{
    public class hkaiStreamingSet : IHavokObject
    {
        public List<hkaiStreamingSetGraphConnection> m_graphConnections;
        public List<hkaiStreamingSetNavMeshConnection> m_meshConnections;
        public uint m_oppositeUid;

        public uint m_thisUid;
        public List<hkaiStreamingSetVolumeConnection> m_volumeConnections;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_thisUid = br.ReadUInt32();
            m_oppositeUid = br.ReadUInt32();
            m_meshConnections = des.ReadClassArray<hkaiStreamingSetNavMeshConnection>(br);
            m_graphConnections = des.ReadClassArray<hkaiStreamingSetGraphConnection>(br);
            m_volumeConnections = des.ReadClassArray<hkaiStreamingSetVolumeConnection>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_thisUid);
            bw.WriteUInt32(m_oppositeUid);
            s.WriteClassArray(bw, m_meshConnections);
            s.WriteClassArray(bw, m_graphConnections);
            s.WriteClassArray(bw, m_volumeConnections);
        }
    }
}