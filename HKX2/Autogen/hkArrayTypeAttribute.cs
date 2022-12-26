using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkArrayTypeAttribute Signatire: 0xd404a39a size: 1 flags: FLAGS_NONE

    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 0 flags:  enum: ArrayType
    
    public class hkArrayTypeAttribute : IHavokObject
    {

        public sbyte m_type;

        public uint Signature => 0xd404a39a;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_type = br.ReadSByte();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteSByte(bw, m_type);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

