using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbStateMachineTransitionInfoArray Signatire: 0xe397b11e size: 32 flags: FLAGS_NONE

    // m_transitions m_class: hkbStateMachineTransitionInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkbStateMachineTransitionInfoArray : hkReferencedObject
    {

        public List<hkbStateMachineTransitionInfo> m_transitions;

        public override uint Signature => 0xe397b11e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_transitions = des.ReadClassArray<hkbStateMachineTransitionInfo>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkbStateMachineTransitionInfo>(bw, m_transitions);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

