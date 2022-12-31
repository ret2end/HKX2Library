using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpMultiRayShape Signatire: 0xea2e7ec9 size: 56 flags: FLAGS_NONE

    // m_rays m_class: hkpMultiRayShapeRay Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_rayPenetrationDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    public partial class hkpMultiRayShape : hkpShape
    {
        public List<hkpMultiRayShapeRay> m_rays;
        public float m_rayPenetrationDistance;

        public override uint Signature => 0xea2e7ec9;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_rays = des.ReadClassArray<hkpMultiRayShapeRay>(br);
            m_rayPenetrationDistance = br.ReadSingle();
            br.Position += 4;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray<hkpMultiRayShapeRay>(bw, m_rays);
            bw.WriteSingle(m_rayPenetrationDistance);
            bw.Position += 4;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkpMultiRayShapeRay>(xe, nameof(m_rays), m_rays);
            xs.WriteFloat(xe, nameof(m_rayPenetrationDistance), m_rayPenetrationDistance);
        }
    }
}

