using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbEventInfo Signatire: 0x5874eed4 size: 4 flags: FLAGS_NONE

    // m_flags m_class:  Type.TYPE_FLAGS Type.TYPE_UINT32 arrSize: 0 offset: 0 flags:  enum: Flags
    
    public class hkbEventInfo : IHavokObject
    {

        public uint m_flags;

        public uint Signature => 0x5874eed4;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_flags = br.ReadUInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteUInt32(m_flags);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

