using System.Xml.Linq;

namespace HKX2
{
    // hkbRoleAttribute Signatire: 0x3eb2e082 size: 4 flags: FLAGS_NONE

    // m_role m_class:  Type.TYPE_ENUM Type.TYPE_INT16 arrSize: 0 offset: 0 flags: FLAGS_NONE enum: Role
    // m_flags m_class:  Type.TYPE_FLAGS Type.TYPE_INT16 arrSize: 0 offset: 2 flags: FLAGS_NONE enum: RoleFlags
    public partial class hkbRoleAttribute : IHavokObject
    {
        public short m_role;
        public short m_flags;

        public virtual uint Signature => 0x3eb2e082;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_role = br.ReadInt16();
            m_flags = br.ReadInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteInt16(bw, m_role);
            bw.WriteInt16(m_flags);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_role = xd.ReadFlag<Role, short>(xe, nameof(m_role));
            m_flags = xd.ReadFlag<RoleFlags, short>(xe, nameof(m_flags));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteEnum<Role, short>(xe, nameof(m_role), m_role);
            xs.WriteFlag<RoleFlags, short>(xe, nameof(m_flags), m_flags);
        }
    }
}

