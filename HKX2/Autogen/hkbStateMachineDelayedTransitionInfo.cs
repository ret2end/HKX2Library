using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbStateMachineDelayedTransitionInfo Signatire: 0x26d5499 size: 24 flags: FLAGS_NONE

    // m_delayedTransition m_class: hkbStateMachineProspectiveTransitionInfo Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_timeDelayed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_isDelayedTransitionReturnToPreviousState m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 20 flags:  enum: 
    // m_wasInAbutRangeLastFrame m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 21 flags:  enum: 
    
    public class hkbStateMachineDelayedTransitionInfo : IHavokObject
    {

        public hkbStateMachineProspectiveTransitionInfo/*struct void*/ m_delayedTransition;
        public float m_timeDelayed;
        public bool m_isDelayedTransitionReturnToPreviousState;
        public bool m_wasInAbutRangeLastFrame;

        public uint Signature => 0x26d5499;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_delayedTransition = new hkbStateMachineProspectiveTransitionInfo();
            m_delayedTransition.Read(des,br);
            m_timeDelayed = br.ReadSingle();
            m_isDelayedTransitionReturnToPreviousState = br.ReadBoolean();
            m_wasInAbutRangeLastFrame = br.ReadBoolean();
            br.Position += 2;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_delayedTransition.Write(s, bw);
            bw.WriteSingle(m_timeDelayed);
            bw.WriteBoolean(m_isDelayedTransitionReturnToPreviousState);
            bw.WriteBoolean(m_wasInAbutRangeLastFrame);
            bw.Position += 2;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

