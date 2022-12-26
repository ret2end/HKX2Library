using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkReflectedFileAttribute Signatire: 0xedb6b8f7 size: 8 flags: FLAGS_NONE

    // m_value m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    
    public class hkReflectedFileAttribute : IHavokObject
    {

        public string m_value;

        public uint Signature => 0xedb6b8f7;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_value = des.ReadStringPointer(br);//m_value = br.ReadASCII();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_value);//bw.WriteASCII(m_value, true);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

