using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpStiffSpringChainDataConstraintInfo Signatire: 0xc624a180 size: 48 flags: FLAGS_NONE

    // m_pivotInA m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_pivotInB m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_springLength m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkpStiffSpringChainDataConstraintInfo : IHavokObject
    {

        public Vector4 m_pivotInA;
        public Vector4 m_pivotInB;
        public float m_springLength;

        public uint Signature => 0xc624a180;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_pivotInA = br.ReadVector4();
            m_pivotInB = br.ReadVector4();
            m_springLength = br.ReadSingle();
            br.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteVector4(m_pivotInA);
            bw.WriteVector4(m_pivotInB);
            bw.WriteSingle(m_springLength);
            bw.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

