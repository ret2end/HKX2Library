using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxMaterialProperty Signatire: 0xd295234d size: 8 flags: FLAGS_NONE

    // m_key m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_value m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    
    public class hkxMaterialProperty : IHavokObject
    {

        public uint m_key;
        public uint m_value;

        public uint Signature => 0xd295234d;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_key = br.ReadUInt32();
            m_value = br.ReadUInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteUInt32(m_key);
            bw.WriteUInt32(m_value);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

