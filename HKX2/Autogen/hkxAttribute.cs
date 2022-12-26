using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxAttribute Signatire: 0x7375cae3 size: 16 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_value m_class: hkReferencedObject Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkxAttribute : IHavokObject
    {

        public string m_name;
        public hkReferencedObject /*pointer struct*/ m_value;

        public uint Signature => 0x7375cae3;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_name = des.ReadStringPointer(br);
            m_value = des.ReadClassPointer<hkReferencedObject>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointer(bw, m_value);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

