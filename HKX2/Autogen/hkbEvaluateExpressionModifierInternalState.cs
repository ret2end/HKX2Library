using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbEvaluateExpressionModifierInternalState Signatire: 0xb414d58e size: 32 flags: FLAGS_NONE

    // m_internalExpressionsData m_class: hkbEvaluateExpressionModifierInternalExpressionData Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkbEvaluateExpressionModifierInternalState : hkReferencedObject
    {
        public List<hkbEvaluateExpressionModifierInternalExpressionData> m_internalExpressionsData;

        public override uint Signature => 0xb414d58e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_internalExpressionsData = des.ReadClassArray<hkbEvaluateExpressionModifierInternalExpressionData>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray<hkbEvaluateExpressionModifierInternalExpressionData>(bw, m_internalExpressionsData);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkbEvaluateExpressionModifierInternalExpressionData>(xe, nameof(m_internalExpressionsData), m_internalExpressionsData);
        }
    }
}

