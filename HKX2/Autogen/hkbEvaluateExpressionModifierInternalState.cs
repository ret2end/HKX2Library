using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbEvaluateExpressionModifierInternalState Signatire: 0xb414d58e size: 32 flags: FLAGS_NONE

    // m_internalExpressionsData m_class: hkbEvaluateExpressionModifierInternalExpressionData Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbEvaluateExpressionModifierInternalState : hkReferencedObject
    {

        public List<hkbEvaluateExpressionModifierInternalExpressionData> m_internalExpressionsData;

        public override uint Signature => 0xb414d58e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_internalExpressionsData = des.ReadClassArray<hkbEvaluateExpressionModifierInternalExpressionData>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkbEvaluateExpressionModifierInternalExpressionData>(bw, m_internalExpressionsData);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

