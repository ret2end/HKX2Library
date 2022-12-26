using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbNamedRealEventPayload Signatire: 0x9c99fd70 size: 32 flags: FLAGS_NONE

    // m_data m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    
    public class hkbNamedRealEventPayload : hkbNamedEventPayload
    {

        public float m_data;

        public override uint Signature => 0x9c99fd70;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_data = br.ReadSingle();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_data);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

