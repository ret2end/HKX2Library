using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbGenerator Signatire: 0xd68aefc size: 72 flags: FLAGS_NONE


    
    public class hkbGenerator : hkbNode
    {



        public override uint Signature => 0xd68aefc;

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

