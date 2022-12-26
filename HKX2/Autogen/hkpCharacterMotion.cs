using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpCharacterMotion Signatire: 0xbafa2bb7 size: 320 flags: FLAGS_NONE


    
    public class hkpCharacterMotion : hkpMotion
    {



        public override uint Signature => 0xbafa2bb7;

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

