using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbNamedIntEventPayload Signatire: 0x3c99bda4 size: 32 flags: FLAGS_NONE

    // m_data m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    
    public class hkbNamedIntEventPayload : hkbNamedEventPayload
    {

        public int m_data;

        public override uint Signature => 0x3c99bda4;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_data = br.ReadInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteInt32(m_data);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

