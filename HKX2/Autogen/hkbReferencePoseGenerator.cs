using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbReferencePoseGenerator Signatire: 0x26a5675a size: 80 flags: FLAGS_NONE

    // m_skeleton m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 72 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbReferencePoseGenerator : hkbGenerator
    {

        public dynamic /* POINTER VOID */ m_skeleton;

        public override uint Signature => 0x26a5675a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            des.ReadEmptyPointer(br);/* m_skeleton POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteVoidPointer(bw);/* m_skeleton POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

