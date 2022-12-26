using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSEventOnFalseToTrueModifier Signatire: 0x81d0777a size: 160 flags: FLAGS_NONE

    // m_bEnableEvent1 m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_bVariableToTest1 m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 81 flags:  enum: 
    // m_EventToSend1 m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_bEnableEvent2 m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 104 flags:  enum: 
    // m_bVariableToTest2 m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 105 flags:  enum: 
    // m_EventToSend2 m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_bEnableEvent3 m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 128 flags:  enum: 
    // m_bVariableToTest3 m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 129 flags:  enum: 
    // m_EventToSend3 m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 136 flags:  enum: 
    // m_bSlot1ActivatedLastFrame m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 152 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_bSlot2ActivatedLastFrame m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 153 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_bSlot3ActivatedLastFrame m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 154 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class BSEventOnFalseToTrueModifier : hkbModifier
    {

        public bool m_bEnableEvent1;
        public bool m_bVariableToTest1;
        public hkbEventProperty/*struct void*/ m_EventToSend1;
        public bool m_bEnableEvent2;
        public bool m_bVariableToTest2;
        public hkbEventProperty/*struct void*/ m_EventToSend2;
        public bool m_bEnableEvent3;
        public bool m_bVariableToTest3;
        public hkbEventProperty/*struct void*/ m_EventToSend3;
        public bool m_bSlot1ActivatedLastFrame;
        public bool m_bSlot2ActivatedLastFrame;
        public bool m_bSlot3ActivatedLastFrame;

        public override uint Signature => 0x81d0777a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_bEnableEvent1 = br.ReadBoolean();
            m_bVariableToTest1 = br.ReadBoolean();
            br.Position += 6;
            m_EventToSend1 = new hkbEventProperty();
            m_EventToSend1.Read(des,br);
            m_bEnableEvent2 = br.ReadBoolean();
            m_bVariableToTest2 = br.ReadBoolean();
            br.Position += 6;
            m_EventToSend2 = new hkbEventProperty();
            m_EventToSend2.Read(des,br);
            m_bEnableEvent3 = br.ReadBoolean();
            m_bVariableToTest3 = br.ReadBoolean();
            br.Position += 6;
            m_EventToSend3 = new hkbEventProperty();
            m_EventToSend3.Read(des,br);
            m_bSlot1ActivatedLastFrame = br.ReadBoolean();
            m_bSlot2ActivatedLastFrame = br.ReadBoolean();
            m_bSlot3ActivatedLastFrame = br.ReadBoolean();
            br.Position += 5;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteBoolean(m_bEnableEvent1);
            bw.WriteBoolean(m_bVariableToTest1);
            bw.Position += 6;
            m_EventToSend1.Write(s, bw);
            bw.WriteBoolean(m_bEnableEvent2);
            bw.WriteBoolean(m_bVariableToTest2);
            bw.Position += 6;
            m_EventToSend2.Write(s, bw);
            bw.WriteBoolean(m_bEnableEvent3);
            bw.WriteBoolean(m_bVariableToTest3);
            bw.Position += 6;
            m_EventToSend3.Write(s, bw);
            bw.WriteBoolean(m_bSlot1ActivatedLastFrame);
            bw.WriteBoolean(m_bSlot2ActivatedLastFrame);
            bw.WriteBoolean(m_bSlot3ActivatedLastFrame);
            bw.Position += 5;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

