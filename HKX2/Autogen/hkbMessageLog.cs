using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbMessageLog Signatire: 0x26a196c5 size: 16 flags: FLAGS_NONE

    // m_messages m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 0 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_maxMessages m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbMessageLog : IHavokObject
    {

        public dynamic /* POINTER VOID */ m_messages;
        public int m_maxMessages;

        public uint Signature => 0x26a196c5;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            des.ReadEmptyPointer(br);/* m_messages POINTER VOID */
            m_maxMessages = br.ReadInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteVoidPointer(bw);/* m_messages POINTER VOID */
            bw.WriteInt32(m_maxMessages);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

