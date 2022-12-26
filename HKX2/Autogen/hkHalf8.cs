using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkHalf8 Signatire: 0x7684dc80 size: 16 flags: FLAGS_NONE

    // m_quad m_class:  Type.TYPE_HALF Type.TYPE_VOID arrSize: 8 offset: 0 flags: ALIGN_8|FLAGS_NONE enum: 
    
    public class hkHalf8 : IHavokObject
    {

        public List<Half> m_quad;

        public uint Signature => 0x7684dc80;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_quad = des.ReadHalfCStyleArray(br, 8);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteHalfCStyleArray(bw, m_quad);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

