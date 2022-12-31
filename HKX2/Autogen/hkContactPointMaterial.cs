using System.Xml.Linq;

namespace HKX2
{
    // hkContactPointMaterial Signatire: 0x4e32287c size: 16 flags: FLAGS_NONE

    // m_userData m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_friction m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_restitution m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 9 flags: FLAGS_NONE enum: 
    // m_maxImpulse m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 10 flags: FLAGS_NONE enum: 
    // m_flags m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 11 flags: FLAGS_NONE enum: 
    public partial class hkContactPointMaterial : IHavokObject
    {
        public ulong m_userData;
        public byte m_friction;
        public byte m_restitution;
        public byte m_maxImpulse;
        public byte m_flags;

        public virtual uint Signature => 0x4e32287c;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_userData = br.ReadUInt64();
            m_friction = br.ReadByte();
            m_restitution = br.ReadByte();
            m_maxImpulse = br.ReadByte();
            m_flags = br.ReadByte();
            br.Position += 4;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt64(m_userData);
            bw.WriteByte(m_friction);
            bw.WriteByte(m_restitution);
            bw.WriteByte(m_maxImpulse);
            bw.WriteByte(m_flags);
            bw.Position += 4;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumber(xe, nameof(m_userData), m_userData);
            xs.WriteNumber(xe, nameof(m_friction), m_friction);
            xs.WriteNumber(xe, nameof(m_restitution), m_restitution);
            xs.WriteNumber(xe, nameof(m_maxImpulse), m_maxImpulse);
            xs.WriteNumber(xe, nameof(m_flags), m_flags);
        }
    }
}

