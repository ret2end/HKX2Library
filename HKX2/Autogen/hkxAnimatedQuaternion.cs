using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxAnimatedQuaternion Signatire: 0xb4f01baa size: 32 flags: FLAGS_NONE

    // m_quaternions m_class:  Type.TYPE_ARRAY Type.TYPE_QUATERNION arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkxAnimatedQuaternion : hkReferencedObject
    {

        public List<Quaternion> m_quaternions;

        public override uint Signature => 0xb4f01baa;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_quaternions = des.ReadQuaternionArray(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteQuaternionArray(bw, m_quaternions);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

