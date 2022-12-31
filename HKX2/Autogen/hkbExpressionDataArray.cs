using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbExpressionDataArray Signatire: 0x4b9ee1a2 size: 32 flags: FLAGS_NONE

    // m_expressionsData m_class: hkbExpressionData Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkbExpressionDataArray : hkReferencedObject
    {
        public List<hkbExpressionData> m_expressionsData;

        public override uint Signature => 0x4b9ee1a2;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_expressionsData = des.ReadClassArray<hkbExpressionData>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray<hkbExpressionData>(bw, m_expressionsData);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkbExpressionData>(xe, nameof(m_expressionsData), m_expressionsData);
        }
    }
}

