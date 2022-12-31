using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpConvexVerticesShapeFourVectors Signatire: 0x3d80c5bf size: 48 flags: FLAGS_NONE

    // m_x m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_y m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_z m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    public partial class hkpConvexVerticesShapeFourVectors : IHavokObject
    {
        public Vector4 m_x;
        public Vector4 m_y;
        public Vector4 m_z;

        public virtual uint Signature => 0x3d80c5bf;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_x = br.ReadVector4();
            m_y = br.ReadVector4();
            m_z = br.ReadVector4();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteVector4(m_x);
            bw.WriteVector4(m_y);
            bw.WriteVector4(m_z);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteVector4(xe, nameof(m_x), m_x);
            xs.WriteVector4(xe, nameof(m_y), m_y);
            xs.WriteVector4(xe, nameof(m_z), m_z);
        }
    }
}

