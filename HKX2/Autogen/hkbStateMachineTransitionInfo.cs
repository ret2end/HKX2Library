using System.Xml.Linq;

namespace HKX2
{
    // hkbStateMachineTransitionInfo Signatire: 0xcdec8025 size: 72 flags: FLAGS_NONE

    // m_triggerInterval m_class: hkbStateMachineTimeInterval Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_initiateInterval m_class: hkbStateMachineTimeInterval Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_transition m_class: hkbTransitionEffect Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_condition m_class: hkbCondition Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_eventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_toStateId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 52 flags: FLAGS_NONE enum: 
    // m_fromNestedStateId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 56 flags: FLAGS_NONE enum: 
    // m_toNestedStateId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 60 flags: FLAGS_NONE enum: 
    // m_priority m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_flags m_class:  Type.TYPE_FLAGS Type.TYPE_INT16 arrSize: 0 offset: 66 flags: FLAGS_NONE enum: TransitionFlags
    public partial class hkbStateMachineTransitionInfo : IHavokObject
    {
        public hkbStateMachineTimeInterval m_triggerInterval = new hkbStateMachineTimeInterval();
        public hkbStateMachineTimeInterval m_initiateInterval = new hkbStateMachineTimeInterval();
        public hkbTransitionEffect m_transition;
        public hkbCondition m_condition;
        public int m_eventId;
        public int m_toStateId;
        public int m_fromNestedStateId;
        public int m_toNestedStateId;
        public short m_priority;
        public short m_flags;

        public virtual uint Signature => 0xcdec8025;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_triggerInterval = new hkbStateMachineTimeInterval();
            m_triggerInterval.Read(des, br);
            m_initiateInterval = new hkbStateMachineTimeInterval();
            m_initiateInterval.Read(des, br);
            m_transition = des.ReadClassPointer<hkbTransitionEffect>(br);
            m_condition = des.ReadClassPointer<hkbCondition>(br);
            m_eventId = br.ReadInt32();
            m_toStateId = br.ReadInt32();
            m_fromNestedStateId = br.ReadInt32();
            m_toNestedStateId = br.ReadInt32();
            m_priority = br.ReadInt16();
            m_flags = br.ReadInt16();
            br.Position += 4;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
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
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_triggerInterval = xd.ReadClass<hkbStateMachineTimeInterval>(xe, nameof(m_triggerInterval));
            m_initiateInterval = xd.ReadClass<hkbStateMachineTimeInterval>(xe, nameof(m_initiateInterval));
            m_transition = xd.ReadClassPointer<hkbTransitionEffect>(xe, nameof(m_transition));
            m_condition = xd.ReadClassPointer<hkbCondition>(xe, nameof(m_condition));
            m_eventId = xd.ReadInt32(xe, nameof(m_eventId));
            m_toStateId = xd.ReadInt32(xe, nameof(m_toStateId));
            m_fromNestedStateId = xd.ReadInt32(xe, nameof(m_fromNestedStateId));
            m_toNestedStateId = xd.ReadInt32(xe, nameof(m_toNestedStateId));
            m_priority = xd.ReadInt16(xe, nameof(m_priority));
            m_flags = xd.ReadFlag<TransitionFlags, short>(xe, nameof(m_flags));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClass<hkbStateMachineTimeInterval>(xe, nameof(m_triggerInterval), m_triggerInterval);
            xs.WriteClass<hkbStateMachineTimeInterval>(xe, nameof(m_initiateInterval), m_initiateInterval);
            xs.WriteClassPointer(xe, nameof(m_transition), m_transition);
            xs.WriteClassPointer(xe, nameof(m_condition), m_condition);
            xs.WriteNumber(xe, nameof(m_eventId), m_eventId);
            xs.WriteNumber(xe, nameof(m_toStateId), m_toStateId);
            xs.WriteNumber(xe, nameof(m_fromNestedStateId), m_fromNestedStateId);
            xs.WriteNumber(xe, nameof(m_toNestedStateId), m_toNestedStateId);
            xs.WriteNumber(xe, nameof(m_priority), m_priority);
            xs.WriteFlag<TransitionFlags, short>(xe, nameof(m_flags), m_flags);
        }
    }
}

