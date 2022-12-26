using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConvexListShape Signatire: 0x450b26e8 size: 128 flags: FLAGS_NONE

    // m_minDistanceToUseConvexHullForGetClosestPoints m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_aabbHalfExtents m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_aabbCenter m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_useCachedAabb m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_childShapes m_class: hkpConvexShape Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 104 flags:  enum: 
    
    public class hkpConvexListShape : hkpConvexShape
    {

        public float m_minDistanceToUseConvexHullForGetClosestPoints;
        public Vector4 m_aabbHalfExtents;
        public Vector4 m_aabbCenter;
        public bool m_useCachedAabb;
        public List<hkpConvexShape> m_childShapes;

        public override uint Signature => 0x450b26e8;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 8;
            m_minDistanceToUseConvexHullForGetClosestPoints = br.ReadSingle();
            br.Position += 12;
            m_aabbHalfExtents = br.ReadVector4();
            m_aabbCenter = br.ReadVector4();
            m_useCachedAabb = br.ReadBoolean();
            br.Position += 7;
            m_childShapes = des.ReadClassPointerArray<hkpConvexShape>(br);
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 8;
            bw.WriteSingle(m_minDistanceToUseConvexHullForGetClosestPoints);
            bw.Position += 12;
            bw.WriteVector4(m_aabbHalfExtents);
            bw.WriteVector4(m_aabbCenter);
            bw.WriteBoolean(m_useCachedAabb);
            bw.Position += 7;
            s.WriteClassPointerArray<hkpConvexShape>(bw, m_childShapes);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

