using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbEvent Signatire: 0x3e0fd810 size: 24 flags: FLAGS_NONE

    // m_sender m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 16 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbEvent : hkbEventBase
    {

        public dynamic /* POINTER VOID */ m_sender;

        public override uint Signature => 0x3e0fd810;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            des.ReadEmptyPointer(br);/* m_sender POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteVoidPointer(bw);/* m_sender POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

