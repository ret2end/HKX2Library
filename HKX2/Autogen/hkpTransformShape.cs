using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpTransformShape Signatire: 0x787ef513 size: 144 flags: FLAGS_NONE

    // m_childShape m_class: hkpSingleShapeContainer Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_childShapeSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 48 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_rotation m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_transform m_class:  Type.TYPE_TRANSFORM Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    public partial class hkpTransformShape : hkpShape
    {
        public hkpSingleShapeContainer m_childShape = new hkpSingleShapeContainer();
        public int m_childShapeSize;
        public Quaternion m_rotation;
        public Matrix4x4 m_transform;

        public override uint Signature => 0x787ef513;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_childShape = new hkpSingleShapeContainer();
            m_childShape.Read(des, br);
            m_childShapeSize = br.ReadInt32();
            br.Position += 12;
            m_rotation = des.ReadQuaternion(br);
            m_transform = des.ReadTransform(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_childShape.Write(s, bw);
            bw.WriteInt32(m_childShapeSize);
            bw.Position += 12;
            s.WriteQuaternion(bw, m_rotation);
            s.WriteTransform(bw, m_transform);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_childShape = xd.ReadClass<hkpSingleShapeContainer>(xe, nameof(m_childShape));
            m_childShapeSize = default;
            m_rotation = xd.ReadQuaternion(xe, nameof(m_rotation));
            m_transform = xd.ReadTransform(xe, nameof(m_transform));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkpSingleShapeContainer>(xe, nameof(m_childShape), m_childShape);
            xs.WriteSerializeIgnored(xe, nameof(m_childShapeSize));
            xs.WriteQuaternion(xe, nameof(m_rotation), m_rotation);
            xs.WriteTransform(xe, nameof(m_transform), m_transform);
        }
    }
}

