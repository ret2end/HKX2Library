using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbStateMachineTransitionInfo Signatire: 0xcdec8025 size: 72 flags: FLAGS_NONE

    // m_triggerInterval m_class: hkbStateMachineTimeInterval Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_initiateInterval m_class: hkbStateMachineTimeInterval Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_transition m_class: hkbTransitionEffect Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags:  enum: 
    // m_condition m_class: hkbCondition Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 40 flags:  enum: 
    // m_eventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_toStateId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 52 flags:  enum: 
    // m_fromNestedStateId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 56 flags:  enum: 
    // m_toNestedStateId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 60 flags:  enum: 
    // m_priority m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_flags m_class:  Type.TYPE_FLAGS Type.TYPE_INT16 arrSize: 0 offset: 66 flags:  enum: TransitionFlags
    
    public class hkbStateMachineTransitionInfo : IHavokObject
    {

        public hkbStateMachineTimeInterval/*struct void*/ m_triggerInterval;
        public hkbStateMachineTimeInterval/*struct void*/ m_initiateInterval;
        public hkbTransitionEffect /*pointer struct*/ m_transition;
        public hkbCondition /*pointer struct*/ m_condition;
        public int m_eventId;
        public int m_toStateId;
        public int m_fromNestedStateId;
        public int m_toNestedStateId;
        public short m_priority;
        public short m_flags;

        public uint Signature => 0xcdec8025;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_triggerInterval = new hkbStateMachineTimeInterval();
            m_triggerInterval.Read(des,br);
            m_initiateInterval = new hkbStateMachineTimeInterval();
            m_initiateInterval.Read(des,br);
            m_transition = des.ReadClassPointer<hkbTransitionEffect>(br);
            m_condition = des.ReadClassPointer<hkbCondition>(br);
            m_eventId = br.ReadInt32();
            m_toStateId = br.ReadInt32();
            m_fromNestedStateId = br.ReadInt32();
            m_toNestedStateId = br.ReadInt32();
            m_priority = br.ReadInt16();
            m_flags = br.ReadInt16();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_triggerInterval.Write(s, bw);
            m_initiateInterval.Write(s, bw);
            s.WriteClassPointer(bw, m_transition);
            s.WriteClassPointer(bw, m_condition);
            bw.WriteInt32(m_eventId);
            bw.WriteInt32(m_toStateId);
            bw.WriteInt32(m_fromNestedStateId);
            bw.WriteInt32(m_toNestedStateId);
            bw.WriteInt16(m_priority);
            bw.WriteInt16(m_flags);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}
