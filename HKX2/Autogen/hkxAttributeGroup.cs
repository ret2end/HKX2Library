using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxAttributeGroup Signatire: 0x345ca95d size: 24 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_attributes m_class: hkxAttribute Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkxAttributeGroup : IHavokObject
    {

        public string m_name;
        public List<hkxAttribute> m_attributes;

        public uint Signature => 0x345ca95d;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_name = des.ReadStringPointer(br);
            m_attributes = des.ReadClassArray<hkxAttribute>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_name);
            s.WriteClassArray<hkxAttribute>(bw, m_attributes);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

