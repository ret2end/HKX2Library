using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpRigidBody Signatire: 0x75f8d805 size: 720 flags: FLAGS_NONE


    
    public class hkpRigidBody : hkpEntity
    {



        public override uint Signature => 0x75f8d805;

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

