using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpConvexTranslateShape Signatire: 0x5ba0a5f7 size: 80 flags: FLAGS_NONE

    // m_translation m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    public partial class hkpConvexTranslateShape : hkpConvexTransformShapeBase
    {
        public Vector4 m_translation;

        public override uint Signature => 0x5ba0a5f7;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_translation = br.ReadVector4();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteVector4(m_translation);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4(xe, nameof(m_translation), m_translation);
        }
    }
}

