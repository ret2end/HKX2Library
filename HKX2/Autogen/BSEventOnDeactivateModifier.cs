using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSEventOnDeactivateModifier Signatire: 0x1062d993 size: 96 flags: FLAGS_NONE

    // m_event m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    
    public class BSEventOnDeactivateModifier : hkbModifier
    {

        public hkbEventProperty/*struct void*/ m_event;

        public override uint Signature => 0x1062d993;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_event = new hkbEventProperty();
            m_event.Read(des,br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_event.Write(s, bw);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

