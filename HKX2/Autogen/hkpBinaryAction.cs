using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpBinaryAction Signatire: 0xc00f3403 size: 64 flags: FLAGS_NONE

    // m_entityA m_class: hkpEntity Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags:  enum: 
    // m_entityB m_class: hkpEntity Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 56 flags:  enum: 
    
    public class hkpBinaryAction : hkpAction
    {

        public hkpEntity /*pointer struct*/ m_entityA;
        public hkpEntity /*pointer struct*/ m_entityB;

        public override uint Signature => 0xc00f3403;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_entityA = des.ReadClassPointer<hkpEntity>(br);
            m_entityB = des.ReadClassPointer<hkpEntity>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_entityA);
            s.WriteClassPointer(bw, m_entityB);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

