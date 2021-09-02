using System.Collections.Generic;

namespace HKX2
{
    public class hkpCollisionFilterList : hkpCollisionFilter
    {
        public List<hkpCollisionFilter> m_collisionFilters;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_collisionFilters = des.ReadClassPointerArray<hkpCollisionFilter>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_collisionFilters);
        }
    }
}