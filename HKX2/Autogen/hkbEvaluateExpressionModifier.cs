using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbEvaluateExpressionModifier Signatire: 0xf900f6be size: 112 flags: FLAGS_NONE

    // m_expressions m_class: hkbExpressionDataArray Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_compiledExpressionSet m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 88 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_internalExpressionsData m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 96 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbEvaluateExpressionModifier : hkbModifier
    {
        public hkbExpressionDataArray m_expressions;
        public dynamic m_compiledExpressionSet;
        public List<dynamic> m_internalExpressionsData;

        public override uint Signature => 0xf900f6be;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_expressions = des.ReadClassPointer<hkbExpressionDataArray>(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_expressions);
            s.WriteVoidPointer(bw);
            s.WriteVoidArray(bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_expressions = xd.ReadClassPointer<hkbExpressionDataArray>(xe, nameof(m_expressions));
            m_compiledExpressionSet = default;
            m_internalExpressionsData = default;
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_expressions), m_expressions);
            xs.WriteSerializeIgnored(xe, nameof(m_compiledExpressionSet));
            xs.WriteSerializeIgnored(xe, nameof(m_internalExpressionsData));
        }
    }
}

