using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkSphere Signatire: 0x143dff99 size: 16 flags: FLAGS_NONE

    // m_pos m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    
    public class hkSphere : IHavokObject
    {

        public Vector4 m_pos;

        public uint Signature => 0x143dff99;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_pos = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteVector4(m_pos);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

