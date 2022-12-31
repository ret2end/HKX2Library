using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpMoppCodeCodeInfo Signatire: 0xd8fdbb08 size: 16 flags: FLAGS_NONE

    // m_offset m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    public partial class hkpMoppCodeCodeInfo : IHavokObject
    {
        public Vector4 m_offset;

        public virtual uint Signature => 0xd8fdbb08;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_offset = br.ReadVector4();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteVector4(m_offset);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteVector4(xe, nameof(m_offset), m_offset);
        }
    }
}

