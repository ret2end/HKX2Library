using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkClass Signatire: 0x75585ef6 size: 80 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_parent m_class: hkClass Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 8 flags:  enum: 
    // m_objectSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_numImplementedInterfaces m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 20 flags:  enum: 
    // m_declaredEnums m_class: hkClassEnum Type.TYPE_SIMPLEARRAY Type.TYPE_STRUCT arrSize: 0 offset: 24 flags:  enum: 
    // m_declaredMembers m_class: hkClassMember Type.TYPE_SIMPLEARRAY Type.TYPE_STRUCT arrSize: 0 offset: 40 flags:  enum: 
    // m_defaults m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 56 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_attributes m_class: hkCustomAttributes Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 64 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_flags m_class:  Type.TYPE_FLAGS Type.TYPE_UINT32 arrSize: 0 offset: 72 flags:  enum: FlagValues
    // m_describedVersion m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 76 flags:  enum: 

    public class hkClass : IHavokObject
    {

        public string m_name;
        public hkClass /*pointer struct*/ m_parent;
        public int m_objectSize;
        public int m_numImplementedInterfaces;
        public dynamic /*simpleArray struct*/ m_declaredEnums;
        public dynamic /*simpleArray struct*/ m_declaredMembers;
        public dynamic /* POINTER VOID */ m_defaults;
        public hkCustomAttributes /*pointer struct*/ m_attributes;
        public uint m_flags;
        public int m_describedVersion;

        public uint Signature => 0x75585ef6;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_name = des.ReadStringPointer(br);//m_name = br.ReadASCII();
            m_parent = des.ReadClassPointer<hkClass>(br);
            m_objectSize = br.ReadInt32();
            m_numImplementedInterfaces = br.ReadInt32();
            throw new NotImplementedException("TPYE_SIMPLEARRAY");/*simple array*/
            throw new NotImplementedException("TPYE_SIMPLEARRAY");/*simple array*/
            des.ReadEmptyPointer(br);/* m_defaults POINTER VOID */
            m_attributes = des.ReadClassPointer<hkCustomAttributes>(br);
            m_flags = br.ReadUInt32();
            m_describedVersion = br.ReadInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_name);//bw.WriteASCII(m_name, true);
            s.WriteClassPointer(bw, m_parent);
            bw.WriteInt32(m_objectSize);
            bw.WriteInt32(m_numImplementedInterfaces);
            throw new NotImplementedException("TPYE_SIMPLEARRAY");/*simple array*/
            throw new NotImplementedException("TPYE_SIMPLEARRAY");/*simple array*/
            s.WriteVoidPointer(bw);/* m_defaults POINTER VOID */
            s.WriteClassPointer(bw, m_attributes);
            bw.WriteUInt32(m_flags);
            bw.WriteInt32(m_describedVersion);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

