using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSIStateManagerModifierBSIStateManagerStateListener Signatire: 0x99463586 size: 24 flags: FLAGS_NONE

    // m_pStateManager m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 16 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class BSIStateManagerModifierBSIStateManagerStateListener : hkbStateListener
    {

        public dynamic /* POINTER VOID */ m_pStateManager;

        public override uint Signature => 0x99463586;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            des.ReadEmptyPointer(br);/* m_pStateManager POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteVoidPointer(bw);/* m_pStateManager POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

