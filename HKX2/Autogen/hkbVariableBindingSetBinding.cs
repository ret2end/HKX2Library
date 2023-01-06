using System.Xml.Linq;

namespace HKX2
{
    // hkbVariableBindingSetBinding Signatire: 0x4d592f72 size: 40 flags: FLAGS_NONE

    // m_memberPath m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_memberClass m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 8 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_offsetInObjectPlusOne m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 16 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_offsetInArrayPlusOne m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 20 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_rootVariableIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 24 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_variableIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 28 flags: FLAGS_NONE enum: 
    // m_bitIndex m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_bindingType m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 33 flags: FLAGS_NONE enum: BindingType
    // m_memberType m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 34 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_variableType m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 35 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_flags m_class:  Type.TYPE_FLAGS Type.TYPE_INT8 arrSize: 0 offset: 36 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbVariableBindingSetBinding : IHavokObject
    {
        public string m_memberPath;
        public dynamic m_memberClass;
        public int m_offsetInObjectPlusOne;
        public int m_offsetInArrayPlusOne;
        public int m_rootVariableIndex;
        public int m_variableIndex;
        public sbyte m_bitIndex;
        public sbyte m_bindingType;
        public byte m_memberType;
        public sbyte m_variableType;
        public sbyte m_flags;

        public virtual uint Signature => 0x4d592f72;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_memberPath = des.ReadStringPointer(br);
            des.ReadEmptyPointer(br);
            m_offsetInObjectPlusOne = br.ReadInt32();
            m_offsetInArrayPlusOne = br.ReadInt32();
            m_rootVariableIndex = br.ReadInt32();
            m_variableIndex = br.ReadInt32();
            m_bitIndex = br.ReadSByte();
            m_bindingType = br.ReadSByte();
            m_memberType = br.ReadByte();
            m_variableType = br.ReadSByte();
            m_flags = br.ReadSByte();
            br.Position += 3;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_memberPath);
            s.WriteVoidPointer(bw);
            bw.WriteInt32(m_offsetInObjectPlusOne);
            bw.WriteInt32(m_offsetInArrayPlusOne);
            bw.WriteInt32(m_rootVariableIndex);
            bw.WriteInt32(m_variableIndex);
            bw.WriteSByte(m_bitIndex);
            s.WriteSByte(bw, m_bindingType);
            s.WriteByte(bw, m_memberType);
            bw.WriteSByte(m_variableType);
            bw.WriteSByte(m_flags);
            bw.Position += 3;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_memberPath = xd.ReadString(xe, nameof(m_memberPath));
            m_memberClass = default;
            m_offsetInObjectPlusOne = default;
            m_offsetInArrayPlusOne = default;
            m_rootVariableIndex = default;
            m_variableIndex = xd.ReadInt32(xe, nameof(m_variableIndex));
            m_bitIndex = xd.ReadSByte(xe, nameof(m_bitIndex));
            m_bindingType = xd.ReadFlag<BindingType, sbyte>(xe, nameof(m_bindingType));
            m_memberType = default;
            m_variableType = default;
            m_flags = default;
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteString(xe, nameof(m_memberPath), m_memberPath);
            xs.WriteSerializeIgnored(xe, nameof(m_memberClass));
            xs.WriteSerializeIgnored(xe, nameof(m_offsetInObjectPlusOne));
            xs.WriteSerializeIgnored(xe, nameof(m_offsetInArrayPlusOne));
            xs.WriteSerializeIgnored(xe, nameof(m_rootVariableIndex));
            xs.WriteNumber(xe, nameof(m_variableIndex), m_variableIndex);
            xs.WriteNumber(xe, nameof(m_bitIndex), m_bitIndex);
            xs.WriteEnum<BindingType, sbyte>(xe, nameof(m_bindingType), m_bindingType);
            xs.WriteSerializeIgnored(xe, nameof(m_memberType));
            xs.WriteSerializeIgnored(xe, nameof(m_variableType));
            xs.WriteSerializeIgnored(xe, nameof(m_flags));
        }
    }
}

