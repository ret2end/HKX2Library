using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpMultiRayShape Signatire: 0xea2e7ec9 size: 56 flags: FLAGS_NONE

    // m_rays m_class: hkpMultiRayShapeRay Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 32 flags:  enum: 
    // m_rayPenetrationDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    
    public class hkpMultiRayShape : hkpShape
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

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkpMultiRayShapeRay>(bw, m_rays);
            bw.WriteSingle(m_rayPenetrationDistance);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

