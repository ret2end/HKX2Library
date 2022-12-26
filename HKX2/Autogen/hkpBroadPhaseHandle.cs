using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpBroadPhaseHandle Signatire: 0x940569dc size: 4 flags: FLAGS_NONE

    // m_id m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpBroadPhaseHandle : IHavokObject
    {

        public uint m_id;

        public virtual uint Signature => 0x940569dc;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_id = br.ReadUInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteUInt32(m_id);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

