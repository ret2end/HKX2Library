using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkClassMember Signatire: 0x5c7ea4c2 size: 40 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_class m_class: hkClass Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_enum m_class: hkClassEnum Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 24 flags: FLAGS_NONE enum: Type
    // m_subtype m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 25 flags: FLAGS_NONE enum: Type
    // m_cArraySize m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 26 flags: FLAGS_NONE enum: 
    // m_flags m_class:  Type.TYPE_FLAGS Type.TYPE_UINT16 arrSize: 0 offset: 28 flags: FLAGS_NONE enum: FlagValues
    // m_offset m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 30 flags: FLAGS_NONE enum: 
    // m_attributes m_class: hkCustomAttributes Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkClassMember : IHavokObject
    {
        public string m_name { set; get; } = "";
        public hkClass? m_class { set; get; } = default;
        public hkClassEnum? m_enum { set; get; } = default;
        public byte m_type { set; get; } = default;
        public byte m_subtype { set; get; } = default;
        public short m_cArraySize { set; get; } = default;
        public ushort m_flags { set; get; } = default;
        public ushort m_offset { set; get; } = default;
        private hkCustomAttributes? m_attributes { set; get; } = default;

        public virtual uint Signature => 0x5c7ea4c2;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_name = des.ReadStringPointer(br);
            m_class = des.ReadClassPointer<hkClass>(br);
            m_enum = des.ReadClassPointer<hkClassEnum>(br);
            m_type = br.ReadByte();
            m_subtype = br.ReadByte();
            m_cArraySize = br.ReadInt16();
            m_flags = br.ReadUInt16();
            m_offset = br.ReadUInt16();
            m_attributes = des.ReadClassPointer<hkCustomAttributes>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteCStringPointer(bw, m_name);
            s.WriteClassPointer(bw, m_class);
            s.WriteClassPointer(bw, m_enum);
            bw.WriteByte(m_type);
            bw.WriteByte(m_subtype);
            bw.WriteInt16(m_cArraySize);
            bw.WriteUInt16(m_flags);
            bw.WriteUInt16(m_offset);
            s.WriteClassPointer(bw, m_attributes);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_name = xd.ReadString(xe, nameof(m_name));
            m_class = xd.ReadClassPointer<hkClass>(xe, nameof(m_class));
            m_enum = xd.ReadClassPointer<hkClassEnum>(xe, nameof(m_enum));
            m_type = xd.ReadFlag<Type, byte>(xe, nameof(m_type));
            m_subtype = xd.ReadFlag<Type, byte>(xe, nameof(m_subtype));
            m_cArraySize = xd.ReadInt16(xe, nameof(m_cArraySize));
            m_flags = xd.ReadFlag<FlagValues, ushort>(xe, nameof(m_flags));
            m_offset = xd.ReadUInt16(xe, nameof(m_offset));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteString(xe, nameof(m_name), m_name);
            xs.WriteClassPointer(xe, nameof(m_class), m_class);
            xs.WriteClassPointer(xe, nameof(m_enum), m_enum);
            xs.WriteEnum<Type, byte>(xe, nameof(m_type), m_type);
            xs.WriteEnum<Type, byte>(xe, nameof(m_subtype), m_subtype);
            xs.WriteNumber(xe, nameof(m_cArraySize), m_cArraySize);
            xs.WriteFlag<FlagValues, ushort>(xe, nameof(m_flags), m_flags);
            xs.WriteNumber(xe, nameof(m_offset), m_offset);
            xs.WriteSerializeIgnored(xe, nameof(m_attributes));
        }
    }
}

