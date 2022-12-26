using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkDescriptionAttribute Signatire: 0xe9f9578a size: 8 flags: FLAGS_NONE

    // m_string m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    
    public class hkDescriptionAttribute : IHavokObject
    {

        public string m_string;

        public uint Signature => 0xe9f9578a;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_string = des.ReadStringPointer(br);//m_string = br.ReadASCII();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_string);//bw.WriteASCII(m_string, true);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

