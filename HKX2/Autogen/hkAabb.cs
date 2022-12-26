using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkAabb Signatire: 0x4a948b16 size: 32 flags: FLAGS_NONE

    // m_min m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_max m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkAabb : IHavokObject
    {

        public Vector4 m_min;
        public Vector4 m_max;

        public uint Signature => 0x4a948b16;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_min = br.ReadVector4();
            m_max = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteVector4(m_min);
            bw.WriteVector4(m_max);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

