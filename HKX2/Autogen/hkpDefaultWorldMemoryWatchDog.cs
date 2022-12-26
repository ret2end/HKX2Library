using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpDefaultWorldMemoryWatchDog Signatire: 0x77d6b19f size: 24 flags: FLAGS_NONE

    // m_freeHeapMemoryRequested m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkpDefaultWorldMemoryWatchDog : hkWorldMemoryAvailableWatchDog
    {

        public int m_freeHeapMemoryRequested;

        public override uint Signature => 0x77d6b19f;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_freeHeapMemoryRequested = br.ReadInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteInt32(m_freeHeapMemoryRequested);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

