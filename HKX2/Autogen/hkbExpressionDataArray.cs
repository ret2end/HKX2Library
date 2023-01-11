using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbExpressionDataArray Signatire: 0x4b9ee1a2 size: 32 flags: FLAGS_NONE

    // m_expressionsData m_class: hkbExpressionData Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkbExpressionDataArray : hkReferencedObject
    {
        public IList<hkbExpressionData> m_expressionsData { set; get; } = new List<hkbExpressionData>();

        public override uint Signature => 0x4b9ee1a2;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_expressionsData = des.ReadClassArray<hkbExpressionData>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_expressionsData);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_expressionsData = xd.ReadClassArray<hkbExpressionData>(xe, nameof(m_expressionsData));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkbExpressionData>(xe, nameof(m_expressionsData), m_expressionsData);
        }
    }
}

