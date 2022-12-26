using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPairCollisionFilter Signatire: 0x4abc140e size: 96 flags: FLAGS_NONE

    // m_disabledPairs m_class: hkpPairCollisionFilterMapPairFilterKeyOverrideType Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 72 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_childFilter m_class: hkpCollisionFilter Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 88 flags:  enum: 
    
    public class hkpPairCollisionFilter : hkpCollisionFilter
    {

        public hkpPairCollisionFilterMapPairFilterKeyOverrideType/*struct void*/ m_disabledPairs;
        public hkpCollisionFilter /*pointer struct*/ m_childFilter;

        public override uint Signature => 0x4abc140e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_disabledPairs = new hkpPairCollisionFilterMapPairFilterKeyOverrideType();
            m_disabledPairs.Read(des,br);
            m_childFilter = des.ReadClassPointer<hkpCollisionFilter>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_disabledPairs.Write(s, bw);
            s.WriteClassPointer(bw, m_childFilter);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

