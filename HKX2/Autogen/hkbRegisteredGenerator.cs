using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbRegisteredGenerator Signatire: 0x58b1d082 size: 96 flags: FLAGS_NONE

    // m_generator m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_relativePosition m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_relativeDirection m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    public partial class hkbRegisteredGenerator : hkbBindable
    {
        public hkbGenerator m_generator;
        public Vector4 m_relativePosition;
        public Vector4 m_relativeDirection;

        public override uint Signature => 0x58b1d082;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_generator = des.ReadClassPointer<hkbGenerator>(br);
            br.Position += 8;
            m_relativePosition = br.ReadVector4();
            m_relativeDirection = br.ReadVector4();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_generator);
            bw.Position += 8;
            bw.WriteVector4(m_relativePosition);
            bw.WriteVector4(m_relativeDirection);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_generator = xd.ReadClassPointer<hkbGenerator>(xe, nameof(m_generator));
            m_relativePosition = xd.ReadVector4(xe, nameof(m_relativePosition));
            m_relativeDirection = xd.ReadVector4(xe, nameof(m_relativeDirection));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_generator), m_generator);
            xs.WriteVector4(xe, nameof(m_relativePosition), m_relativePosition);
            xs.WriteVector4(xe, nameof(m_relativeDirection), m_relativeDirection);
        }
    }
}

