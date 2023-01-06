using System.Xml.Linq;

namespace HKX2
{
    // hkpConvexTransformShapeBase Signatire: 0xfbd72f9 size: 64 flags: FLAGS_NONE

    // m_childShape m_class: hkpSingleShapeContainer Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_childShapeSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 56 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkpConvexTransformShapeBase : hkpConvexShape
    {
        public hkpSingleShapeContainer m_childShape = new hkpSingleShapeContainer();
        public int m_childShapeSize;

        public override uint Signature => 0xfbd72f9;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_childShape = new hkpSingleShapeContainer();
            m_childShape.Read(des, br);
            m_childShapeSize = br.ReadInt32();
            br.Position += 4;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_childShape.Write(s, bw);
            bw.WriteInt32(m_childShapeSize);
            bw.Position += 4;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_childShape = xd.ReadClass<hkpSingleShapeContainer>(xe, nameof(m_childShape));
            m_childShapeSize = default;
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkpSingleShapeContainer>(xe, nameof(m_childShape), m_childShape);
            xs.WriteSerializeIgnored(xe, nameof(m_childShapeSize));
        }
    }
}

