using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbNamedEventPayload Signatire: 0x65bdd3a0 size: 24 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbNamedEventPayload : hkbEventPayload
    {

        public string m_name;

        public override uint Signature => 0x65bdd3a0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_name = des.ReadStringPointer(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

