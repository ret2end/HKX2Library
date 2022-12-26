using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpGenericConstraintDataScheme Signatire: 0x11fd6f6c size: 80 flags: FLAGS_NONE

    // m_info m_class: hkpGenericConstraintDataSchemeConstraintInfo Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_data m_class:  Type.TYPE_ARRAY Type.TYPE_VECTOR4 arrSize: 0 offset: 16 flags:  enum: 
    // m_commands m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 32 flags:  enum: 
    // m_modifiers m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 48 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_motors m_class: hkpConstraintMotor Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 64 flags:  enum: 
    
    public class hkpGenericConstraintDataScheme : IHavokObject
    {

        public hkpGenericConstraintDataSchemeConstraintInfo/*struct void*/ m_info;
        public List<Vector4> m_data;
        public List<int> m_commands;
        //public List<> m_modifiers;
        public List<hkpConstraintMotor> m_motors;

        public uint Signature => 0x11fd6f6c;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_info = new hkpGenericConstraintDataSchemeConstraintInfo();
            m_info.Read(des,br);
            m_data = des.ReadVector4Array(br);
            m_commands = des.ReadInt32Array(br);
            des.ReadEmptyArray(br); //m_modifiers = des.ReadClassPointerArray<>(br);
            m_motors = des.ReadClassPointerArray<hkpConstraintMotor>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_info.Write(s, bw);
            s.WriteVector4Array(bw, m_data);
            s.WriteInt32Array(bw, m_commands);
            s.WriteVoidArray(bw); //s.WriteClassPointerArray<>(bw, m_modifiers);
            s.WriteClassPointerArray<hkpConstraintMotor>(bw, m_motors);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

