using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpMoppCodeCodeInfo Signatire: 0xd8fdbb08 size: 16 flags: FLAGS_NONE

    // m_offset m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    
    public class hkpMoppCodeCodeInfo : IHavokObject
    {

        public Vector4 m_offset;

        public uint Signature => 0xd8fdbb08;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_offset = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteVector4(m_offset);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

