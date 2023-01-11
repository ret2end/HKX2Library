using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpMoppBvTreeShape Signatire: 0x90b29d39 size: 112 flags: FLAGS_NONE

    // m_child m_class: hkpSingleShapeContainer Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_childSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 96 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkpMoppBvTreeShape : hkMoppBvTreeShapeBase
    {
        public hkpSingleShapeContainer m_child { set; get; } = new();
        private int m_childSize { set; get; } = default;

        public override uint Signature => 0x90b29d39;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_child.Read(des, br);
            m_childSize = br.ReadInt32();
            br.Position += 12;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_child.Write(s, bw);
            bw.WriteInt32(m_childSize);
            bw.Position += 12;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_child = xd.ReadClass<hkpSingleShapeContainer>(xe, nameof(m_child));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkpSingleShapeContainer>(xe, nameof(m_child), m_child);
            xs.WriteSerializeIgnored(xe, nameof(m_childSize));
        }
    }
}

