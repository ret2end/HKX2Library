using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConvexListFilter Signatire: 0x81d074a4 size: 16 flags: FLAGS_NONE


    
    public class hkpConvexListFilter : hkReferencedObject
    {



        public override uint Signature => 0x81d074a4;

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

