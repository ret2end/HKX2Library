using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbExpressionCondition Signatire: 0x1c3c1045 size: 32 flags: FLAGS_NONE

    // m_expression m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_compiledExpressionSet m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 24 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbExpressionCondition : hkbCondition
    {

        public string m_expression;
        public dynamic /* POINTER VOID */ m_compiledExpressionSet;

        public override uint Signature => 0x1c3c1045;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_expression = des.ReadStringPointer(br);
            des.ReadEmptyPointer(br);/* m_compiledExpressionSet POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteStringPointer(bw, m_expression);
            s.WriteVoidPointer(bw);/* m_compiledExpressionSet POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

