using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbStateMachineEventPropertyArray Signatire: 0xb07b4388 size: 32 flags: FLAGS_NONE

    // m_events m_class: hkbEventProperty Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbStateMachineEventPropertyArray : hkReferencedObject
    {

        public List<hkbEventProperty> m_events;

        public override uint Signature => 0xb07b4388;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_events = des.ReadClassArray<hkbEventProperty>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkbEventProperty>(bw, m_events);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

