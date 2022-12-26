using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConstrainedSystemFilter Signatire: 0x20a447fe size: 88 flags: FLAGS_NONE

    // m_otherFilter m_class: hkpCollisionFilter Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags:  enum: 
    
    public class hkpConstrainedSystemFilter : hkpCollisionFilter
    {

        public hkpCollisionFilter /*pointer struct*/ m_otherFilter;

        public override uint Signature => 0x20a447fe;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 8;
            m_otherFilter = des.ReadClassPointer<hkpCollisionFilter>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 8;
            s.WriteClassPointer(bw, m_otherFilter);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

