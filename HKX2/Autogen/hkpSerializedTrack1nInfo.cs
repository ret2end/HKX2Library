using System.Collections.Generic;

namespace HKX2
{
    public class hkpSerializedTrack1nInfo : IHavokObject
    {
        public List<hkpAgent1nSector> m_sectors;
        public List<hkpSerializedSubTrack1nInfo> m_subTracks;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_sectors = des.ReadClassPointerArray<hkpAgent1nSector>(br);
            m_subTracks = des.ReadClassPointerArray<hkpSerializedSubTrack1nInfo>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointerArray(bw, m_sectors);
            s.WriteClassPointerArray(bw, m_subTracks);
        }
    }
}