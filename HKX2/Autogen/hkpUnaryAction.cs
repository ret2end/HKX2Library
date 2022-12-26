using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpUnaryAction Signatire: 0x895532c0 size: 56 flags: FLAGS_NONE

    // m_entity m_class: hkpEntity Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags:  enum: 
    
    public class hkpUnaryAction : hkpAction
    {

        public hkpEntity /*pointer struct*/ m_entity;

        public override uint Signature => 0x895532c0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_entity = des.ReadClassPointer<hkpEntity>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_entity);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

