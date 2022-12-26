using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbStringCondition Signatire: 0x5ab50487 size: 24 flags: FLAGS_NONE

    // m_conditionString m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbStringCondition : hkbCondition
    {

        public string m_conditionString;

        public override uint Signature => 0x5ab50487;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_conditionString = des.ReadStringPointer(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteStringPointer(bw, m_conditionString);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

