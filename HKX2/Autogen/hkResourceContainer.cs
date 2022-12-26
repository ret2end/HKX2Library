using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkResourceContainer Signatire: 0x4e94146 size: 16 flags: FLAGS_NONE


    
    public class hkResourceContainer : hkResourceBase
    {



        public override uint Signature => 0x4e94146;

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

