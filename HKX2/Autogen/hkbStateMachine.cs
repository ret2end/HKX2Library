using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbStateMachine Signatire: 0x816c1dcb size: 264 flags: FLAGS_NONE

    // m_eventToSendWhenStateOrTransitionChanges m_class: hkbEvent Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 72 flags:  enum: 
    // m_startStateChooser m_class: hkbStateChooser Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 96 flags:  enum: 
    // m_startStateId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 104 flags:  enum: 
    // m_returnToPreviousStateEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 108 flags:  enum: 
    // m_randomTransitionEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_transitionToNextHigherStateEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 116 flags:  enum: 
    // m_transitionToNextLowerStateEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 120 flags:  enum: 
    // m_syncVariableIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 124 flags:  enum: 
    // m_currentStateId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 128 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_wrapAroundStateId m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 132 flags:  enum: 
    // m_maxSimultaneousTransitions m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 133 flags:  enum: 
    // m_startStateMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 134 flags:  enum: StartStateMode
    // m_selfTransitionMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 135 flags:  enum: StateMachineSelfTransitionMode
    // m_isActive m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 136 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_states m_class: hkbStateMachineStateInfo Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 144 flags:  enum: 
    // m_wildcardTransitions m_class: hkbStateMachineTransitionInfoArray Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 160 flags:  enum: 
    // m_stateIdToIndexMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 168 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_activeTransitions m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 176 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_transitionFlags m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 192 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_wildcardTransitionFlags m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 208 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_delayedTransitions m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 224 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_timeInState m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 240 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_lastLocalTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 244 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_previousStateId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 248 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_nextStartStateIndexOverride m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 252 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_stateOrTransitionChanged m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 256 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_echoNextUpdate m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 257 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_sCurrentStateIndexAndEntered m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 258 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbStateMachine : hkbGenerator
    {

        public hkbEvent/*struct void*/ m_eventToSendWhenStateOrTransitionChanges;
        public hkbStateChooser /*pointer struct*/ m_startStateChooser;
        public int m_startStateId;
        public int m_returnToPreviousStateEventId;
        public int m_randomTransitionEventId;
        public int m_transitionToNextHigherStateEventId;
        public int m_transitionToNextLowerStateEventId;
        public int m_syncVariableIndex;
        public int m_currentStateId;
        public bool m_wrapAroundStateId;
        public sbyte m_maxSimultaneousTransitions;
        public sbyte m_startStateMode;
        public sbyte m_selfTransitionMode;
        public bool m_isActive;
        public List<hkbStateMachineStateInfo> m_states;
        public hkbStateMachineTransitionInfoArray /*pointer struct*/ m_wildcardTransitions;
        public dynamic /* POINTER VOID */ m_stateIdToIndexMap;
        public List<ulong> m_activeTransitions;
        public List<ulong> m_transitionFlags;
        public List<ulong> m_wildcardTransitionFlags;
        public List<ulong> m_delayedTransitions;
        public float m_timeInState;
        public float m_lastLocalTime;
        public int m_previousStateId;
        public int m_nextStartStateIndexOverride;
        public bool m_stateOrTransitionChanged;
        public bool m_echoNextUpdate;
        public ushort m_sCurrentStateIndexAndEntered;

        public override uint Signature => 0x816c1dcb;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_eventToSendWhenStateOrTransitionChanges = new hkbEvent();
            m_eventToSendWhenStateOrTransitionChanges.Read(des,br);
            m_startStateChooser = des.ReadClassPointer<hkbStateChooser>(br);
            m_startStateId = br.ReadInt32();
            m_returnToPreviousStateEventId = br.ReadInt32();
            m_randomTransitionEventId = br.ReadInt32();
            m_transitionToNextHigherStateEventId = br.ReadInt32();
            m_transitionToNextLowerStateEventId = br.ReadInt32();
            m_syncVariableIndex = br.ReadInt32();
            m_currentStateId = br.ReadInt32();
            m_wrapAroundStateId = br.ReadBoolean();
            m_maxSimultaneousTransitions = br.ReadSByte();
            m_startStateMode = br.ReadSByte();
            m_selfTransitionMode = br.ReadSByte();
            m_isActive = br.ReadBoolean();
            br.Position += 7;
            m_states = des.ReadClassPointerArray<hkbStateMachineStateInfo>(br);
            m_wildcardTransitions = des.ReadClassPointer<hkbStateMachineTransitionInfoArray>(br);
            des.ReadEmptyPointer(br);/* m_stateIdToIndexMap POINTER VOID */
            des.ReadEmptyArray(br); //m_activeTransitions
            des.ReadEmptyArray(br); //m_transitionFlags
            des.ReadEmptyArray(br); //m_wildcardTransitionFlags
            des.ReadEmptyArray(br); //m_delayedTransitions
            m_timeInState = br.ReadSingle();
            m_lastLocalTime = br.ReadSingle();
            m_previousStateId = br.ReadInt32();
            m_nextStartStateIndexOverride = br.ReadInt32();
            m_stateOrTransitionChanged = br.ReadBoolean();
            m_echoNextUpdate = br.ReadBoolean();
            m_sCurrentStateIndexAndEntered = br.ReadUInt16();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_eventToSendWhenStateOrTransitionChanges.Write(s, bw);
            s.WriteClassPointer(bw, m_startStateChooser);
            bw.WriteInt32(m_startStateId);
            bw.WriteInt32(m_returnToPreviousStateEventId);
            bw.WriteInt32(m_randomTransitionEventId);
            bw.WriteInt32(m_transitionToNextHigherStateEventId);
            bw.WriteInt32(m_transitionToNextLowerStateEventId);
            bw.WriteInt32(m_syncVariableIndex);
            bw.WriteInt32(m_currentStateId);
            bw.WriteBoolean(m_wrapAroundStateId);
            bw.WriteSByte(m_maxSimultaneousTransitions);
            s.WriteSByte(bw, m_startStateMode);
            s.WriteSByte(bw, m_selfTransitionMode);
            bw.WriteBoolean(m_isActive);
            bw.Position += 7;
            s.WriteClassPointerArray<hkbStateMachineStateInfo>(bw, m_states);
            s.WriteClassPointer(bw, m_wildcardTransitions);
            s.WriteVoidPointer(bw);/* m_stateIdToIndexMap POINTER VOID */
            s.WriteVoidArray(bw); // m_activeTransitions
            s.WriteVoidArray(bw); // m_transitionFlags
            s.WriteVoidArray(bw); // m_wildcardTransitionFlags
            s.WriteVoidArray(bw); // m_delayedTransitions
            bw.WriteSingle(m_timeInState);
            bw.WriteSingle(m_lastLocalTime);
            bw.WriteInt32(m_previousStateId);
            bw.WriteInt32(m_nextStartStateIndexOverride);
            bw.WriteBoolean(m_stateOrTransitionChanged);
            bw.WriteBoolean(m_echoNextUpdate);
            bw.WriteUInt16(m_sCurrentStateIndexAndEntered);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

