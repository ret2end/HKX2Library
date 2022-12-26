using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkPostFinishAttribute Signatire: 0x903abb2c size: 8 flags: FLAGS_NONE

    // m_postFinishFunction m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 0 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkPostFinishAttribute : IHavokObject
    {

        public dynamic /* POINTER VOID */ m_postFinishFunction;

        public uint Signature => 0x903abb2c;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            des.ReadEmptyPointer(br);/* m_postFinishFunction POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteVoidPointer(bw);/* m_postFinishFunction POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

