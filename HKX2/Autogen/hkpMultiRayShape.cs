using System.Collections.Generic;

namespace HKX2
{
    public class hkpMultiRayShape : hkpShape
    {
        public float m_rayPenetrationDistance;

        public List<hkpMultiRayShapeRay> m_rays;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_rays = des.ReadClassArray<hkpMultiRayShapeRay>(br);
            m_rayPenetrationDistance = br.ReadSingle();
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_rays);
            bw.WriteSingle(m_rayPenetrationDistance);
            bw.WriteUInt32(0);
        }
    }
}