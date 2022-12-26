using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbCondition Signatire: 0xda8c7d7d size: 16 flags: FLAGS_NONE


    
    public class hkbCondition : hkReferencedObject
    {



        public override uint Signature => 0xda8c7d7d;

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

