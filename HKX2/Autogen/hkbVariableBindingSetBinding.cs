using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbVariableBindingSetBinding Signatire: 0x4d592f72 size: 40 flags: FLAGS_NONE

    // m_memberPath m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_memberClass m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 8 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_offsetInObjectPlusOne m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 16 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_offsetInArrayPlusOne m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 20 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_rootVariableIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 24 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_variableIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 28 flags:  enum: 
    // m_bitIndex m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_bindingType m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 33 flags:  enum: BindingType
    // m_memberType m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 34 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_variableType m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 35 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_flags m_class:  Type.TYPE_FLAGS Type.TYPE_INT8 arrSize: 0 offset: 36 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbVariableBindingSetBinding : IHavokObject
    {

        public string m_memberPath;
        public dynamic /* POINTER VOID */ m_memberClass;
        public int m_offsetInObjectPlusOne;
        public int m_offsetInArrayPlusOne;
        public int m_rootVariableIndex;
        public int m_variableIndex;
        public sbyte m_bitIndex;
        public sbyte m_bindingType;
        public byte m_memberType;
        public sbyte m_variableType;
        public sbyte m_flags;

        public uint Signature => 0x4d592f72;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_memberPath = des.ReadStringPointer(br);
            des.ReadEmptyPointer(br);/* m_memberClass POINTER VOID */
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

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_memberPath);
            s.WriteVoidPointer(bw);/* m_memberClass POINTER VOID */
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

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

