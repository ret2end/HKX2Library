using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpCylinderShape Signatire: 0x3e463c3a size: 112 flags: FLAGS_NONE

    // m_cylRadius m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_cylBaseRadiusFactorForHeightFieldCollisions m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 44 flags: FLAGS_NONE enum: 
    // m_vertexA m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_vertexB m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_perpendicular1 m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_perpendicular2 m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    public partial class hkpCylinderShape : hkpConvexShape
    {
        public float m_cylRadius;
        public float m_cylBaseRadiusFactorForHeightFieldCollisions;
        public Vector4 m_vertexA;
        public Vector4 m_vertexB;
        public Vector4 m_perpendicular1;
        public Vector4 m_perpendicular2;

        public override uint Signature => 0x3e463c3a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_cylRadius = br.ReadSingle();
            m_cylBaseRadiusFactorForHeightFieldCollisions = br.ReadSingle();
            m_vertexA = br.ReadVector4();
            m_vertexB = br.ReadVector4();
            m_perpendicular1 = br.ReadVector4();
            m_perpendicular2 = br.ReadVector4();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_cylRadius);
            bw.WriteSingle(m_cylBaseRadiusFactorForHeightFieldCollisions);
            bw.WriteVector4(m_vertexA);
            bw.WriteVector4(m_vertexB);
            bw.WriteVector4(m_perpendicular1);
            bw.WriteVector4(m_perpendicular2);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteFloat(xe, nameof(m_cylRadius), m_cylRadius);
            xs.WriteFloat(xe, nameof(m_cylBaseRadiusFactorForHeightFieldCollisions), m_cylBaseRadiusFactorForHeightFieldCollisions);
            xs.WriteVector4(xe, nameof(m_vertexA), m_vertexA);
            xs.WriteVector4(xe, nameof(m_vertexB), m_vertexB);
            xs.WriteVector4(xe, nameof(m_perpendicular1), m_perpendicular1);
            xs.WriteVector4(xe, nameof(m_perpendicular2), m_perpendicular2);
        }
    }
}

