using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbCompiledExpressionSet Signatire: 0x3a7d76cc size: 56 flags: FLAGS_NONE

    // m_rpn m_class: hkbCompiledExpressionSetToken Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_expressionToRpnIndex m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_numExpressions m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    public partial class hkbCompiledExpressionSet : hkReferencedObject
    {
        public List<hkbCompiledExpressionSetToken> m_rpn = new List<hkbCompiledExpressionSetToken>();
        public List<int> m_expressionToRpnIndex;
        public sbyte m_numExpressions;

        public override uint Signature => 0x3a7d76cc;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_rpn = des.ReadClassArray<hkbCompiledExpressionSetToken>(br);
            m_expressionToRpnIndex = des.ReadInt32Array(br);
            m_numExpressions = br.ReadSByte();
            br.Position += 7;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray<hkbCompiledExpressionSetToken>(bw, m_rpn);
            s.WriteInt32Array(bw, m_expressionToRpnIndex);
            bw.WriteSByte(m_numExpressions);
            bw.Position += 7;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_rpn = xd.ReadClassArray<hkbCompiledExpressionSetToken>(xe, nameof(m_rpn));
            m_expressionToRpnIndex = xd.ReadInt32Array(xe, nameof(m_expressionToRpnIndex));
            m_numExpressions = xd.ReadSByte(xe, nameof(m_numExpressions));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkbCompiledExpressionSetToken>(xe, nameof(m_rpn), m_rpn);
            xs.WriteNumberArray(xe, nameof(m_expressionToRpnIndex), m_expressionToRpnIndex);
            xs.WriteNumber(xe, nameof(m_numExpressions), m_numExpressions);
        }
    }
}

