using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbFootIkModifierInternalLegData Signatire: 0xe5ca3677 size: 32 flags: FLAGS_NONE

    // m_groundPosition m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_footIkSolver m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 16 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbFootIkModifierInternalLegData : IHavokObject
    {
        public Vector4 m_groundPosition;
        public dynamic m_footIkSolver;

        public virtual uint Signature => 0xe5ca3677;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_groundPosition = br.ReadVector4();
            des.ReadEmptyPointer(br);
            br.Position += 8;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteVector4(m_groundPosition);
            s.WriteVoidPointer(bw);
            bw.Position += 8;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_groundPosition = xd.ReadVector4(xe, nameof(m_groundPosition));
            m_footIkSolver = default;
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteVector4(xe, nameof(m_groundPosition), m_groundPosition);
            xs.WriteSerializeIgnored(xe, nameof(m_footIkSolver));
        }
    }
}

