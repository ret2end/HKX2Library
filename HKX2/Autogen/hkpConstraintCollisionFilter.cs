using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConstraintCollisionFilter Signatire: 0xc3b577b1 size: 104 flags: FLAGS_NONE


    
    public class hkpConstraintCollisionFilter : hkpPairCollisionFilter
    {



        public override uint Signature => 0xc3b577b1;

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

