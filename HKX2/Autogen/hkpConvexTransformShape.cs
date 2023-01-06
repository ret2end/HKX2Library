using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpConvexTransformShape Signatire: 0xae3e5017 size: 128 flags: FLAGS_NONE

    // m_transform m_class:  Type.TYPE_TRANSFORM Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    public partial class hkpConvexTransformShape : hkpConvexTransformShapeBase
    {
        public Matrix4x4 m_transform;

        public override uint Signature => 0xae3e5017;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_transform = des.ReadTransform(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteTransform(bw, m_transform);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_transform = xd.ReadTransform(xe, nameof(m_transform));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteTransform(xe, nameof(m_transform), m_transform);
        }
    }
}

