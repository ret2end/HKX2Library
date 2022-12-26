using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkMultiThreadCheck Signatire: 0x11e4408b size: 12 flags: FLAGS_NONE

    // m_threadId m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_stackTraceId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_markCount m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 8 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_markBitStack m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 10 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkMultiThreadCheck : IHavokObject
    {

        public uint m_threadId;
        public int m_stackTraceId;
        public ushort m_markCount;
        public ushort m_markBitStack;

        public uint Signature => 0x11e4408b;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_threadId = br.ReadUInt32();
            m_stackTraceId = br.ReadInt32();
            m_markCount = br.ReadUInt16();
            m_markBitStack = br.ReadUInt16();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteUInt32(m_threadId);
            bw.WriteInt32(m_stackTraceId);
            bw.WriteUInt16(m_markCount);
            bw.WriteUInt16(m_markBitStack);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

