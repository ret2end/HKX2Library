using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkClassMember Signatire: 0x5c7ea4c2 size: 40 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_class m_class: hkClass Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 8 flags:  enum: 
    // m_enum m_class: hkClassEnum Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 24 flags:  enum: Type
    // m_subtype m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 25 flags:  enum: Type
    // m_cArraySize m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 26 flags:  enum: 
    // m_flags m_class:  Type.TYPE_FLAGS Type.TYPE_UINT16 arrSize: 0 offset: 28 flags:  enum: FlagValues
    // m_offset m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 30 flags:  enum: 
    // m_attributes m_class: hkCustomAttributes Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkClassMember : IHavokObject
    {

        public string m_name;
        public hkClass /*pointer struct*/ m_class;
        public hkClassEnum /*pointer struct*/ m_enum;
        public byte m_type;
        public byte m_subtype;
        public short m_cArraySize;
        public ushort m_flags;
        public ushort m_offset;
        public hkCustomAttributes /*pointer struct*/ m_attributes;

        public uint Signature => 0x5c7ea4c2;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_name = des.ReadStringPointer(br);//m_name = br.ReadASCII();
            m_class = des.ReadClassPointer<hkClass>(br);
            m_enum = des.ReadClassPointer<hkClassEnum>(br);
            m_type = br.ReadByte();
            m_subtype = br.ReadByte();
            m_cArraySize = br.ReadInt16();
            m_flags = br.ReadUInt16();
            m_offset = br.ReadUInt16();
            m_attributes = des.ReadClassPointer<hkCustomAttributes>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_name);//bw.WriteASCII(m_name, true);
            s.WriteClassPointer(bw, m_class);
            s.WriteClassPointer(bw, m_enum);
            s.WriteByte(bw, m_type);
            s.WriteByte(bw, m_subtype);
            bw.WriteInt16(m_cArraySize);
            bw.WriteUInt16(m_flags);
            bw.WriteUInt16(m_offset);
            s.WriteClassPointer(bw, m_attributes);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

