using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpDefaultConvexListFilter Signatire: 0xb69c1c02 size: 16 flags: FLAGS_NONE


    
    public class hkpDefaultConvexListFilter : hkpConvexListFilter
    {



        public override uint Signature => 0xb69c1c02;

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

