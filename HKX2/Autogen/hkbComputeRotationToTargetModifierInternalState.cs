using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbComputeRotationToTargetModifierInternalState Signatire: 0x71cd1eb0 size: 32 flags: FLAGS_NONE

    // m_rotationOut m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbComputeRotationToTargetModifierInternalState : hkReferencedObject
    {

        public Quaternion m_rotationOut;

        public override uint Signature => 0x71cd1eb0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_rotationOut = des.ReadQuaternion(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteQuaternion(bw, m_rotationOut);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}
