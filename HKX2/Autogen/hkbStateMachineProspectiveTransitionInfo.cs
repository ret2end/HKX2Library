using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbStateMachineProspectiveTransitionInfo Signatire: 0x3ab09a2e size: 16 flags: FLAGS_NONE

    // m_transitionInfoReference m_class: hkbStateMachineTransitionInfoReference Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_transitionInfoReferenceForTE m_class: hkbStateMachineTransitionInfoReference Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 6 flags:  enum: 
    // m_toStateId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    
    public class hkbStateMachineProspectiveTransitionInfo : IHavokObject
    {

        public hkbStateMachineTransitionInfoReference/*struct void*/ m_transitionInfoReference;
        public hkbStateMachineTransitionInfoReference/*struct void*/ m_transitionInfoReferenceForTE;
        public int m_toStateId;

        public uint Signature => 0x3ab09a2e;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_transitionInfoReference = new hkbStateMachineTransitionInfoReference();
            m_transitionInfoReference.Read(des,br);
            m_transitionInfoReferenceForTE = new hkbStateMachineTransitionInfoReference();
            m_transitionInfoReferenceForTE.Read(des,br);
            m_toStateId = br.ReadInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_transitionInfoReference.Write(s, bw);
            m_transitionInfoReferenceForTE.Write(s, bw);
            bw.WriteInt32(m_toStateId);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

