using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaMeshBindingMapping Signatire: 0x48aceb75 size: 16 flags: FLAGS_NONE

    // m_mapping m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 0 flags:  enum: 
    
    public class hkaMeshBindingMapping : IHavokObject
    {

        public List<short> m_mapping;

        public uint Signature => 0x48aceb75;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_mapping = des.ReadInt16Array(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteInt16Array(bw, m_mapping);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

