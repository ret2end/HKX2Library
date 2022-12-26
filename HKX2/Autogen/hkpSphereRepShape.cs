using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpSphereRepShape Signatire: 0xe7eca7eb size: 32 flags: FLAGS_NONE


    
    public class hkpSphereRepShape : hkpShape
    {



        public override uint Signature => 0xe7eca7eb;

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

