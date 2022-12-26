using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbCompiledExpressionSetToken Signatire: 0xc6aaccc8 size: 8 flags: FLAGS_NONE

    // m_data m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 4 flags:  enum: TokenType
    // m_operator m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 5 flags:  enum: Operator
    
    public class hkbCompiledExpressionSetToken : IHavokObject
    {

        public float m_data;
        public sbyte m_type;
        public sbyte m_operator;

        public uint Signature => 0xc6aaccc8;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_data = br.ReadSingle();
            m_type = br.ReadSByte();
            m_operator = br.ReadSByte();
            br.Position += 2;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteSingle(m_data);
            s.WriteSByte(bw, m_type);
            s.WriteSByte(bw, m_operator);
            bw.Position += 2;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

