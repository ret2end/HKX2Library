using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpViscousSurfaceModifierConstraintAtom Signatire: 0x5c6aa14d size: 48 flags: FLAGS_NONE


    
    public class hkpViscousSurfaceModifierConstraintAtom : hkpModifierConstraintAtom
    {



        public override uint Signature => 0x5c6aa14d;

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

