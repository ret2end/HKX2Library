using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPropertyValue Signatire: 0xc75925aa size: 8 flags: FLAGS_NONE

    // m_data m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    
    public class hkpPropertyValue : IHavokObject
    {

        public ulong m_data;

        public uint Signature => 0xc75925aa;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_data = br.ReadUInt64();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteUInt64(m_data);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

