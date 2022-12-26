using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConstraintChainData Signatire: 0x5facc7ff size: 24 flags: FLAGS_NONE


    
    public class hkpConstraintChainData : hkpConstraintData
    {



        public override uint Signature => 0x5facc7ff;

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

