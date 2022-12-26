using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbCompiledExpressionSet Signatire: 0x3a7d76cc size: 56 flags: FLAGS_NONE

    // m_rpn m_class: hkbCompiledExpressionSetToken Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    // m_expressionToRpnIndex m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 32 flags:  enum: 
    // m_numExpressions m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    
    public class hkbCompiledExpressionSet : hkReferencedObject
    {

        public List<hkbCompiledExpressionSetToken> m_rpn;
        public List<int> m_expressionToRpnIndex;
        public sbyte m_numExpressions;

        public override uint Signature => 0x3a7d76cc;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_rpn = des.ReadClassArray<hkbCompiledExpressionSetToken>(br);
            m_expressionToRpnIndex = des.ReadInt32Array(br);
            m_numExpressions = br.ReadSByte();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkbCompiledExpressionSetToken>(bw, m_rpn);
            s.WriteInt32Array(bw, m_expressionToRpnIndex);
            bw.WriteSByte(m_numExpressions);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

