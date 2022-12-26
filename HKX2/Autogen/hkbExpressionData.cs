using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbExpressionData Signatire: 0x6740042a size: 24 flags: FLAGS_NONE

    // m_expression m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_assignmentVariableIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_assignmentEventIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    // m_eventMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 16 flags:  enum: ExpressionEventMode
    // m_raisedEvent m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 17 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_wasTrueInPreviousFrame m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 18 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbExpressionData : IHavokObject
    {

        public string m_expression;
        public int m_assignmentVariableIndex;
        public int m_assignmentEventIndex;
        public sbyte m_eventMode;
        public bool m_raisedEvent;
        public bool m_wasTrueInPreviousFrame;

        public uint Signature => 0x6740042a;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_expression = des.ReadStringPointer(br);
            m_assignmentVariableIndex = br.ReadInt32();
            m_assignmentEventIndex = br.ReadInt32();
            m_eventMode = br.ReadSByte();
            m_raisedEvent = br.ReadBoolean();
            m_wasTrueInPreviousFrame = br.ReadBoolean();
            br.Position += 5;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_expression);
            bw.WriteInt32(m_assignmentVariableIndex);
            bw.WriteInt32(m_assignmentEventIndex);
            s.WriteSByte(bw, m_eventMode);
            bw.WriteBoolean(m_raisedEvent);
            bw.WriteBoolean(m_wasTrueInPreviousFrame);
            bw.Position += 5;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

