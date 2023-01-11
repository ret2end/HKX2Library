using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbExpressionData Signatire: 0x6740042a size: 24 flags: FLAGS_NONE

    // m_expression m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_assignmentVariableIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_assignmentEventIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    // m_eventMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 16 flags: FLAGS_NONE enum: ExpressionEventMode
    // m_raisedEvent m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 17 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_wasTrueInPreviousFrame m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 18 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbExpressionData : IHavokObject
    {
        public string m_expression { set; get; } = "";
        public int m_assignmentVariableIndex { set; get; } = default;
        public int m_assignmentEventIndex { set; get; } = default;
        public sbyte m_eventMode { set; get; } = default;
        private bool m_raisedEvent { set; get; } = default;
        private bool m_wasTrueInPreviousFrame { set; get; } = default;

        public virtual uint Signature => 0x6740042a;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_expression = des.ReadStringPointer(br);
            m_assignmentVariableIndex = br.ReadInt32();
            m_assignmentEventIndex = br.ReadInt32();
            m_eventMode = br.ReadSByte();
            m_raisedEvent = br.ReadBoolean();
            m_wasTrueInPreviousFrame = br.ReadBoolean();
            br.Position += 5;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_expression);
            bw.WriteInt32(m_assignmentVariableIndex);
            bw.WriteInt32(m_assignmentEventIndex);
            bw.WriteSByte(m_eventMode);
            bw.WriteBoolean(m_raisedEvent);
            bw.WriteBoolean(m_wasTrueInPreviousFrame);
            bw.Position += 5;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_expression = xd.ReadString(xe, nameof(m_expression));
            m_assignmentVariableIndex = xd.ReadInt32(xe, nameof(m_assignmentVariableIndex));
            m_assignmentEventIndex = xd.ReadInt32(xe, nameof(m_assignmentEventIndex));
            m_eventMode = xd.ReadFlag<ExpressionEventMode, sbyte>(xe, nameof(m_eventMode));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteString(xe, nameof(m_expression), m_expression);
            xs.WriteNumber(xe, nameof(m_assignmentVariableIndex), m_assignmentVariableIndex);
            xs.WriteNumber(xe, nameof(m_assignmentEventIndex), m_assignmentEventIndex);
            xs.WriteEnum<ExpressionEventMode, sbyte>(xe, nameof(m_eventMode), m_eventMode);
            xs.WriteSerializeIgnored(xe, nameof(m_raisedEvent));
            xs.WriteSerializeIgnored(xe, nameof(m_wasTrueInPreviousFrame));
        }
    }
}

