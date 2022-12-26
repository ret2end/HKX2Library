using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpCollisionFilterList Signatire: 0x2603bf04 size: 88 flags: FLAGS_NONE

    // m_collisionFilters m_class: hkpCollisionFilter Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 72 flags:  enum: 
    
    public class hkpCollisionFilterList : hkpCollisionFilter
    {

        public List<hkpCollisionFilter> m_collisionFilters;

        public override uint Signature => 0x2603bf04;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_collisionFilters = des.ReadClassPointerArray<hkpCollisionFilter>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkpCollisionFilter>(bw, m_collisionFilters);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

