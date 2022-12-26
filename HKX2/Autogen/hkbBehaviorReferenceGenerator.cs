using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbBehaviorReferenceGenerator Signatire: 0xfcb5423 size: 88 flags: FLAGS_NONE

    // m_behaviorName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 72 flags:  enum: 
    // m_behavior m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 80 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbBehaviorReferenceGenerator : hkbGenerator
    {

        public string m_behaviorName;
        public dynamic /* POINTER VOID */ m_behavior;

        public override uint Signature => 0xfcb5423;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_behaviorName = des.ReadStringPointer(br);
            des.ReadEmptyPointer(br);/* m_behavior POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteStringPointer(bw, m_behaviorName);
            s.WriteVoidPointer(bw);/* m_behavior POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

