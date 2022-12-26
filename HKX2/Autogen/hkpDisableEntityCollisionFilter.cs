using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpDisableEntityCollisionFilter Signatire: 0xfac3351c size: 96 flags: FLAGS_NONE

    // m_disabledEntities m_class: hkpEntity Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 80 flags:  enum: 
    
    public class hkpDisableEntityCollisionFilter : hkpCollisionFilter
    {

        public List<hkpEntity> m_disabledEntities;

        public override uint Signature => 0xfac3351c;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 8;
            m_disabledEntities = des.ReadClassPointerArray<hkpEntity>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 8;
            s.WriteClassPointerArray<hkpEntity>(bw, m_disabledEntities);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

