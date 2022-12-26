using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSEventEveryNEventsModifier Signatire: 0x6030970c size: 128 flags: FLAGS_NONE

    // m_eventToCheckFor m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_eventToSend m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_numberOfEventsBeforeSend m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_minimumNumberOfEventsBeforeSend m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 113 flags:  enum: 
    // m_randomizeNumberOfEvents m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 114 flags:  enum: 
    // m_numberOfEventsSeen m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 116 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_calculatedNumberOfEventsBeforeSend m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 120 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class BSEventEveryNEventsModifier : hkbModifier
    {

        public hkbEventProperty/*struct void*/ m_eventToCheckFor;
        public hkbEventProperty/*struct void*/ m_eventToSend;
        public sbyte m_numberOfEventsBeforeSend;
        public sbyte m_minimumNumberOfEventsBeforeSend;
        public bool m_randomizeNumberOfEvents;
        public int m_numberOfEventsSeen;
        public sbyte m_calculatedNumberOfEventsBeforeSend;

        public override uint Signature => 0x6030970c;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_eventToCheckFor = new hkbEventProperty();
            m_eventToCheckFor.Read(des,br);
            m_eventToSend = new hkbEventProperty();
            m_eventToSend.Read(des,br);
            m_numberOfEventsBeforeSend = br.ReadSByte();
            m_minimumNumberOfEventsBeforeSend = br.ReadSByte();
            m_randomizeNumberOfEvents = br.ReadBoolean();
            br.Position += 1;
            m_numberOfEventsSeen = br.ReadInt32();
            m_calculatedNumberOfEventsBeforeSend = br.ReadSByte();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_eventToCheckFor.Write(s, bw);
            m_eventToSend.Write(s, bw);
            bw.WriteSByte(m_numberOfEventsBeforeSend);
            bw.WriteSByte(m_minimumNumberOfEventsBeforeSend);
            bw.WriteBoolean(m_randomizeNumberOfEvents);
            bw.Position += 1;
            bw.WriteInt32(m_numberOfEventsSeen);
            bw.WriteSByte(m_calculatedNumberOfEventsBeforeSend);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

