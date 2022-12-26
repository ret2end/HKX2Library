using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpArrayAction Signatire: 0x674bcd2d size: 64 flags: FLAGS_NONE

    // m_entities m_class: hkpEntity Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 48 flags:  enum: 
    
    public class hkpArrayAction : hkpAction
    {

        public List<hkpEntity> m_entities;

        public override uint Signature => 0x674bcd2d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_entities = des.ReadClassPointerArray<hkpEntity>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkpEntity>(bw, m_entities);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

