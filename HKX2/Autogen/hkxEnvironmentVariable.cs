using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxEnvironmentVariable Signatire: 0xa6815115 size: 16 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_value m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkxEnvironmentVariable : IHavokObject
    {

        public string m_name;
        public string m_value;

        public uint Signature => 0xa6815115;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_name = des.ReadStringPointer(br);
            m_value = des.ReadStringPointer(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_name);
            s.WriteStringPointer(bw, m_value);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

