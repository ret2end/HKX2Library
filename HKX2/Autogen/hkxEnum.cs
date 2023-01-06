using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkxEnum Signatire: 0xc4e1211 size: 32 flags: FLAGS_NONE

    // m_items m_class: hkxEnumItem Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkxEnum : hkReferencedObject
    {
        public List<hkxEnumItem> m_items = new List<hkxEnumItem>();

        public override uint Signature => 0xc4e1211;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_items = des.ReadClassArray<hkxEnumItem>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray<hkxEnumItem>(bw, m_items);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_items = xd.ReadClassArray<hkxEnumItem>(xe, nameof(m_items));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkxEnumItem>(xe, nameof(m_items), m_items);
        }
    }
}

