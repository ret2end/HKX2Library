using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbVariableValue Signatire: 0xb99bd6a size: 4 flags: FLAGS_NONE

    // m_value m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    
    public class hkbVariableValue : IHavokObject
    {

        public int m_value;

        public uint Signature => 0xb99bd6a;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_value = br.ReadInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteInt32(m_value);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

