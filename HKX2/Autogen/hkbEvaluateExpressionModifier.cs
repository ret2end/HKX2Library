using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbEvaluateExpressionModifier Signatire: 0xf900f6be size: 112 flags: FLAGS_NONE

    // m_expressions m_class: hkbExpressionDataArray Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags:  enum: 
    // m_compiledExpressionSet m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 88 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_internalExpressionsData m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 96 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbEvaluateExpressionModifier : hkbModifier
    {

        public hkbExpressionDataArray /*pointer struct*/ m_expressions;
        public dynamic /* POINTER VOID */ m_compiledExpressionSet;
        public List<ulong> m_internalExpressionsData;

        public override uint Signature => 0xf900f6be;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_expressions = des.ReadClassPointer<hkbExpressionDataArray>(br);
            des.ReadEmptyPointer(br);/* m_compiledExpressionSet POINTER VOID */
            des.ReadEmptyArray(br); //m_internalExpressionsData

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_expressions);
            s.WriteVoidPointer(bw);/* m_compiledExpressionSet POINTER VOID */
            s.WriteVoidArray(bw); // m_internalExpressionsData

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

