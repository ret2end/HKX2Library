using System;
using System.Xml.Linq;

namespace HKX2
{
    // hkClassEnum Signatire: 0x8a3609cf size: 40 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_items m_class: hkClassEnumItem Type.TYPE_SIMPLEARRAY Type.TYPE_STRUCT arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_attributes m_class: hkCustomAttributes Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_flags m_class:  Type.TYPE_FLAGS Type.TYPE_UINT32 arrSize: 0 offset: 32 flags: FLAGS_NONE enum: FlagValues
    public partial class hkClassEnum : IHavokObject
    {
        public string m_name;
        public dynamic m_items;
        public hkCustomAttributes m_attributes;
        public uint m_flags;

        public virtual uint Signature => 0x8a3609cf;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_name = des.ReadStringPointer(br);
            throw new NotImplementedException("TPYE_SIMPLEARRAY");
            m_attributes = des.ReadClassPointer<hkCustomAttributes>(br);
            m_flags = br.ReadUInt32();
            br.Position += 4;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_name);
            throw new NotImplementedException("TPYE_SIMPLEARRAY");
            s.WriteClassPointer(bw, m_attributes);
            bw.WriteUInt32(m_flags);
            bw.Position += 4;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteString(xe, nameof(m_name), m_name);
            throw new NotImplementedException("TPYE_SIMPLEARRAY");
            xs.WriteSerializeIgnored(xe, nameof(m_attributes));
            xs.WriteFlag<FlagValues, uint>(xe, nameof(m_flags), m_flags);
        }
    }
}

