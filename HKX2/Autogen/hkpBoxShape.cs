using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpBoxShape Signatire: 0x3444d2d5 size: 64 flags: FLAGS_NONE

    // m_halfExtents m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    public partial class hkpBoxShape : hkpConvexShape
    {
        public Vector4 m_halfExtents;

        public override uint Signature => 0x3444d2d5;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 8;
            m_halfExtents = br.ReadVector4();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 8;
            bw.WriteVector4(m_halfExtents);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4(xe, nameof(m_halfExtents), m_halfExtents);
        }
    }
}

