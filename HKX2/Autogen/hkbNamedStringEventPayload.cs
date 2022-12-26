using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbNamedStringEventPayload Signatire: 0x6caa9113 size: 32 flags: FLAGS_NONE

    // m_data m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    
    public class hkbNamedStringEventPayload : hkbNamedEventPayload
    {

        public string m_data;

        public override uint Signature => 0x6caa9113;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_data = des.ReadStringPointer(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteStringPointer(bw, m_data);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

