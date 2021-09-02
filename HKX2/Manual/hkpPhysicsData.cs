using System.Collections.Generic;

namespace HKX2
{
    public class hkpPhysicsData : hkReferencedObject
    {
        public List<hkpPhysicsSystem> m_systems;

        public hkpWorldCinfo m_worldCinfo;
        public override uint Signature => 0x47A8CA83;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_worldCinfo = des.ReadClassPointer<hkpWorldCinfo>(br);
            m_systems = des.ReadClassPointerArray<hkpPhysicsSystem>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_worldCinfo);
            s.WriteClassPointerArray(bw, m_systems);
        }
    }
}