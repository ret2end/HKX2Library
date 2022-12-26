using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpFixedRigidMotion Signatire: 0x64abf85c size: 320 flags: FLAGS_NONE


    
    public class hkpFixedRigidMotion : hkpKeyframedRigidMotion
    {



        public override uint Signature => 0x64abf85c;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

