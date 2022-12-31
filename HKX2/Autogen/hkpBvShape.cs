using System.Xml.Linq;

namespace HKX2
{
    // hkpBvShape Signatire: 0x286eb64c size: 56 flags: FLAGS_NONE

    // m_boundingVolumeShape m_class: hkpShape Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_childShape m_class: hkpSingleShapeContainer Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    public partial class hkpBvShape : hkpShape
    {
        public hkpShape m_boundingVolumeShape;
        public hkpSingleShapeContainer m_childShape;

        public override uint Signature => 0x286eb64c;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_boundingVolumeShape = des.ReadClassPointer<hkpShape>(br);
            m_childShape = new hkpSingleShapeContainer();
            m_childShape.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_boundingVolumeShape);
            m_childShape.Write(s, bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_boundingVolumeShape), m_boundingVolumeShape);
            xs.WriteClass<hkpSingleShapeContainer>(xe, nameof(m_childShape), m_childShape);
        }
    }
}

