using System.Xml.Linq;

namespace HKX2
{
    // hkbVariableInfo Signatire: 0x9e746ba2 size: 6 flags: FLAGS_NONE

    // m_role m_class: hkbRoleAttribute Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 4 flags: FLAGS_NONE enum: VariableType
    public partial class hkbVariableInfo : IHavokObject
    {
        public hkbRoleAttribute m_role;
        public sbyte m_type;

        public virtual uint Signature => 0x9e746ba2;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_role = new hkbRoleAttribute();
            m_role.Read(des, br);
            m_type = br.ReadSByte();
            br.Position += 1;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_role.Write(s, bw);
            s.WriteSByte(bw, m_type);
            bw.Position += 1;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_role = xd.ReadClass<hkbRoleAttribute>(xe, nameof(m_role));
            // XXX: inconsistent type, it just work.
            m_type = (sbyte)xd.ReadFlag<VariableType, uint>(xe, nameof(m_type));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClass<hkbRoleAttribute>(xe, nameof(m_role), m_role);
            xs.WriteEnum<VariableType, sbyte>(xe, nameof(m_type), m_type);
        }
    }
}

