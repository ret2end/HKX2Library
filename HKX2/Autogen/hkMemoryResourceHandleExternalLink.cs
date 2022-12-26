using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkMemoryResourceHandleExternalLink Signatire: 0x3144d17c size: 16 flags: FLAGS_NONE

    // m_memberName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_externalId m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkMemoryResourceHandleExternalLink : IHavokObject
    {

        public string m_memberName;
        public string m_externalId;

        public uint Signature => 0x3144d17c;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_memberName = des.ReadStringPointer(br);
            m_externalId = des.ReadStringPointer(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_memberName);
            s.WriteStringPointer(bw, m_externalId);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

