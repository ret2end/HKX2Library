using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpTriSampledHeightFieldBvTreeShape Signatire: 0x58e1e585 size: 80 flags: FLAGS_NONE

    // m_childContainer m_class: hkpSingleShapeContainer Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_childSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 56 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_wantAabbRejectionTest m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 60 flags: FLAGS_NONE enum: 
    // m_padding m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 12 offset: 61 flags: FLAGS_NONE enum: 
    public partial class hkpTriSampledHeightFieldBvTreeShape : hkpBvTreeShape
    {
        public hkpSingleShapeContainer m_childContainer;
        public int m_childSize;
        public bool m_wantAabbRejectionTest;
        public List<byte> m_padding;

        public override uint Signature => 0x58e1e585;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_childContainer = new hkpSingleShapeContainer();
            m_childContainer.Read(des, br);
            m_childSize = br.ReadInt32();
            m_wantAabbRejectionTest = br.ReadBoolean();
            m_padding = des.ReadByteCStyleArray(br, 12);
            br.Position += 7;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_childContainer.Write(s, bw);
            bw.WriteInt32(m_childSize);
            bw.WriteBoolean(m_wantAabbRejectionTest);
            s.WriteByteCStyleArray(bw, m_padding);
            bw.Position += 7;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkpSingleShapeContainer>(xe, nameof(m_childContainer), m_childContainer);
            xs.WriteSerializeIgnored(xe, nameof(m_childSize));
            xs.WriteBoolean(xe, nameof(m_wantAabbRejectionTest), m_wantAabbRejectionTest);
            xs.WriteNumberArray(xe, nameof(m_padding), m_padding);
        }
    }
}

