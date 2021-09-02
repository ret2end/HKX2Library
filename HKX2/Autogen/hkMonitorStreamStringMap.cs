using System.Collections.Generic;

namespace HKX2
{
    public class hkMonitorStreamStringMap : IHavokObject
    {
        public List<hkMonitorStreamStringMapStringMap> m_map;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_map = des.ReadClassArray<hkMonitorStreamStringMapStringMap>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassArray(bw, m_map);
        }
    }
}