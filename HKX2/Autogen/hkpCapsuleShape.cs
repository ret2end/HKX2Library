using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpCapsuleShape Signatire: 0xdd0b1fd3 size: 80 flags: FLAGS_NONE

    // m_vertexA m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_vertexB m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    public partial class hkpCapsuleShape : hkpConvexShape
    {
        public Vector4 m_vertexA;
        public Vector4 m_vertexB;

        public override uint Signature => 0xdd0b1fd3;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 8;
            m_vertexA = br.ReadVector4();
            m_vertexB = br.ReadVector4();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 8;
            bw.WriteVector4(m_vertexA);
            bw.WriteVector4(m_vertexB);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4(xe, nameof(m_vertexA), m_vertexA);
            xs.WriteVector4(xe, nameof(m_vertexB), m_vertexB);
        }
    }
}

