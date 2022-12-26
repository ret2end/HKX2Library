using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkTraceStreamTitle Signatire: 0x6a4ca82c size: 32 flags: FLAGS_NOT_SERIALIZABLE

    // m_value m_class:  Type.TYPE_CHAR Type.TYPE_VOID arrSize: 32 offset: 0 flags:  enum: 
    
    public class hkTraceStreamTitle : IHavokObject
    {

        public string m_value;

        public uint Signature => 0x6a4ca82c;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_value = br.ReadASCII(32);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteASCII(m_value);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

