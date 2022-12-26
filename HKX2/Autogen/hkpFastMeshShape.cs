using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpFastMeshShape Signatire: 0x3d3da311 size: 128 flags: FLAGS_NONE


    
    public class hkpFastMeshShape : hkpMeshShape
    {



        public override uint Signature => 0x3d3da311;

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

