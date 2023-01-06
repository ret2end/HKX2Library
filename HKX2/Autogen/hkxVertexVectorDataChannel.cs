using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkxVertexVectorDataChannel Signatire: 0x2ea63179 size: 32 flags: FLAGS_NONE

    // m_perVertexVectors m_class:  Type.TYPE_ARRAY Type.TYPE_VECTOR4 arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    public partial class hkxVertexVectorDataChannel : hkReferencedObject
    {
        public List<Vector4> m_perVertexVectors;

        public override uint Signature => 0x2ea63179;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_perVertexVectors = des.ReadVector4Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVector4Array(bw, m_perVertexVectors);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_perVertexVectors = xd.ReadVector4Array(xe, nameof(m_perVertexVectors));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4Array(xe, nameof(m_perVertexVectors), m_perVertexVectors);
        }
    }
}

