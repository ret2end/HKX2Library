using System.Xml.Linq;

namespace HKX2
{
    // hkbExpressionCondition Signatire: 0x1c3c1045 size: 32 flags: FLAGS_NONE

    // m_expression m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_compiledExpressionSet m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 24 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbExpressionCondition : hkbCondition
    {
        public string m_expression;
        public dynamic m_compiledExpressionSet;

        public override uint Signature => 0x1c3c1045;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_expression = des.ReadStringPointer(br);
            des.ReadEmptyPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_expression);
            s.WriteVoidPointer(bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_expression = xd.ReadString(xe, nameof(m_expression));
            m_compiledExpressionSet = default;
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteString(xe, nameof(m_expression), m_expression);
            xs.WriteSerializeIgnored(xe, nameof(m_compiledExpressionSet));
        }
    }
}

