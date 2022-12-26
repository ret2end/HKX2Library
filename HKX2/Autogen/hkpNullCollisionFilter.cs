using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpNullCollisionFilter Signatire: 0xb120a34f size: 72 flags: FLAGS_NONE


    
    public class hkpNullCollisionFilter : hkpCollisionFilter
    {



        public override uint Signature => 0xb120a34f;

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

