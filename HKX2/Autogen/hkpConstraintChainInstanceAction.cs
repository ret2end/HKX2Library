using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConstraintChainInstanceAction Signatire: 0xc3971189 size: 56 flags: FLAGS_NONE

    // m_constraintInstance m_class: hkpConstraintChainInstance Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags: ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpConstraintChainInstanceAction : hkpAction
    {

        public hkpConstraintChainInstance /*pointer struct*/ m_constraintInstance;

        public override uint Signature => 0xc3971189;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_constraintInstance = des.ReadClassPointer<hkpConstraintChainInstance>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_constraintInstance);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

