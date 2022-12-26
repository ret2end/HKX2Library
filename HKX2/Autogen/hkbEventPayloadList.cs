using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbEventPayloadList Signatire: 0x3d2dbd34 size: 32 flags: FLAGS_NONE

    // m_payloads m_class: hkbEventPayload Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbEventPayloadList : hkbEventPayload
    {

        public List<hkbEventPayload> m_payloads;

        public override uint Signature => 0x3d2dbd34;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_payloads = des.ReadClassPointerArray<hkbEventPayload>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkbEventPayload>(bw, m_payloads);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

