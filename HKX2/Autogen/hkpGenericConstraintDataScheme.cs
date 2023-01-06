using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpGenericConstraintDataScheme Signatire: 0x11fd6f6c size: 80 flags: FLAGS_NONE

    // m_info m_class: hkpGenericConstraintDataSchemeConstraintInfo Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_data m_class:  Type.TYPE_ARRAY Type.TYPE_VECTOR4 arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_commands m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_modifiers m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 48 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_motors m_class: hkpConstraintMotor Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    public partial class hkpGenericConstraintDataScheme : IHavokObject
    {
        public hkpGenericConstraintDataSchemeConstraintInfo m_info = new hkpGenericConstraintDataSchemeConstraintInfo();
        public List<Vector4> m_data;
        public List<int> m_commands;
        public List<dynamic> m_modifiers = new List<dynamic>();
        public List<hkpConstraintMotor> m_motors = new List<hkpConstraintMotor>();

        public virtual uint Signature => 0x11fd6f6c;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_info = new hkpGenericConstraintDataSchemeConstraintInfo();
            m_info.Read(des, br);
            m_data = des.ReadVector4Array(br);
            m_commands = des.ReadInt32Array(br);
            des.ReadEmptyArray(br);
            m_motors = des.ReadClassPointerArray<hkpConstraintMotor>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_info.Write(s, bw);
            s.WriteVector4Array(bw, m_data);
            s.WriteInt32Array(bw, m_commands);
            s.WriteVoidArray(bw);
            s.WriteClassPointerArray<hkpConstraintMotor>(bw, m_motors);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_info = new hkpGenericConstraintDataSchemeConstraintInfo();
            m_data = xd.ReadVector4Array(xe, nameof(m_data));
            m_commands = xd.ReadInt32Array(xe, nameof(m_commands));
            m_modifiers = default;
            m_motors = xd.ReadClassPointerArray<hkpConstraintMotor>(xe, nameof(m_motors));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteSerializeIgnored(xe, nameof(m_info));
            xs.WriteVector4Array(xe, nameof(m_data), m_data);
            xs.WriteNumberArray(xe, nameof(m_commands), m_commands);
            xs.WriteSerializeIgnored(xe, nameof(m_modifiers));
            xs.WriteClassPointerArray<hkpConstraintMotor>(xe, nameof(m_motors), m_motors);
        }
    }
}

