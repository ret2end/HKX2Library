using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbStateMachineInternalState Signatire: 0xbd1a7502 size: 104 flags: FLAGS_NONE

    // m_activeTransitions m_class: hkbStateMachineActiveTransitionInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    // m_transitionFlags m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 32 flags:  enum: 
    // m_wildcardTransitionFlags m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 48 flags:  enum: 
    // m_delayedTransitions m_class: hkbStateMachineDelayedTransitionInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 64 flags:  enum: 
    // m_timeInState m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_lastLocalTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags:  enum: 
    // m_currentStateId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_previousStateId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 92 flags:  enum: 
    // m_nextStartStateIndexOverride m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_stateOrTransitionChanged m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 100 flags:  enum: 
    // m_echoNextUpdate m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 101 flags:  enum: 
    
    public class hkbStateMachineInternalState : hkReferencedObject
    {

        public List<hkbStateMachineActiveTransitionInfo> m_activeTransitions;
        public List<byte> m_transitionFlags;
        public List<byte> m_wildcardTransitionFlags;
        public List<hkbStateMachineDelayedTransitionInfo> m_delayedTransitions;
        public float m_timeInState;
        public float m_lastLocalTime;
        public int m_currentStateId;
        public int m_previousStateId;
        public int m_nextStartStateIndexOverride;
        public bool m_stateOrTransitionChanged;
        public bool m_echoNextUpdate;

        public override uint Signature => 0xbd1a7502;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_activeTransitions = des.ReadClassArray<hkbStateMachineActiveTransitionInfo>(br);
            m_transitionFlags = des.ReadByteArray(br);
            m_wildcardTransitionFlags = des.ReadByteArray(br);
            m_delayedTransitions = des.ReadClassArray<hkbStateMachineDelayedTransitionInfo>(br);
            m_timeInState = br.ReadSingle();
            m_lastLocalTime = br.ReadSingle();
            m_currentStateId = br.ReadInt32();
            m_previousStateId = br.ReadInt32();
            m_nextStartStateIndexOverride = br.ReadInt32();
            m_stateOrTransitionChanged = br.ReadBoolean();
            m_echoNextUpdate = br.ReadBoolean();
            br.Position += 2;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkbStateMachineActiveTransitionInfo>(bw, m_activeTransitions);
            s.WriteByteArray(bw, m_transitionFlags);
            s.WriteByteArray(bw, m_wildcardTransitionFlags);
            s.WriteClassArray<hkbStateMachineDelayedTransitionInfo>(bw, m_delayedTransitions);
            bw.WriteSingle(m_timeInState);
            bw.WriteSingle(m_lastLocalTime);
            bw.WriteInt32(m_currentStateId);
            bw.WriteInt32(m_previousStateId);
            bw.WriteInt32(m_nextStartStateIndexOverride);
            bw.WriteBoolean(m_stateOrTransitionChanged);
            bw.WriteBoolean(m_echoNextUpdate);
            bw.Position += 2;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

