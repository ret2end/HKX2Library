using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpBallSocketChainDataConstraintInfo Signatire: 0xc9cbedf2 size: 32 flags: FLAGS_NONE

    // m_pivotInA m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_pivotInB m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkpBallSocketChainDataConstraintInfo : IHavokObject
    {

        public Vector4 m_pivotInA;
        public Vector4 m_pivotInB;

        public uint Signature => 0xc9cbedf2;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_pivotInA = br.ReadVector4();
            m_pivotInB = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteVector4(m_pivotInA);
            bw.WriteVector4(m_pivotInB);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

