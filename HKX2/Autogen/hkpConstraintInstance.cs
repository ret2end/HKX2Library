using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConstraintInstance Signatire: 0x34eba5f size: 112 flags: FLAGS_NONE

    // m_owner m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 16 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_data m_class: hkpConstraintData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags:  enum: 
    // m_constraintModifiers m_class: hkpModifierConstraintAtom Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags:  enum: 
    // m_entities m_class: hkpEntity Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 2 offset: 40 flags:  enum: 
    // m_priority m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 56 flags:  enum: ConstraintPriority
    // m_wantRuntime m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 57 flags:  enum: 
    // m_destructionRemapInfo m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 58 flags:  enum: OnDestructionRemapInfo
    // m_listeners m_class: hkpConstraintInstanceSmallArraySerializeOverrideType Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 64 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_userData m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_internal m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 96 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_uid m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 104 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 

    public class hkpConstraintInstance : hkReferencedObject
    {

        public dynamic /* POINTER VOID */ m_owner;
        public hkpConstraintData /*pointer struct*/ m_data;
        public hkpModifierConstraintAtom /*pointer struct*/ m_constraintModifiers;
        public List<hkpEntity /*pointer struct*/> m_entities;
        public byte m_priority;
        public bool m_wantRuntime;
        public byte m_destructionRemapInfo;
        public hkpConstraintInstanceSmallArraySerializeOverrideType/*struct void*/ m_listeners;
        public string m_name;
        public ulong m_userData;
        public dynamic /* POINTER VOID */ m_internal;
        public uint m_uid;

        public override uint Signature => 0x34eba5f;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            des.ReadEmptyPointer(br);/* m_owner POINTER VOID */
            m_data = des.ReadClassPointer<hkpConstraintData>(br);
            m_constraintModifiers = des.ReadClassPointer<hkpModifierConstraintAtom>(br);
            m_entities = des.ReadClassPointerCStyleArray<hkpEntity>(br, 2);//m_entities = des.ReadClassPointer<hkpEntity>(br);
            m_priority = br.ReadByte();
            m_wantRuntime = br.ReadBoolean();
            m_destructionRemapInfo = br.ReadByte();
            br.Position += 5;
            m_listeners = new hkpConstraintInstanceSmallArraySerializeOverrideType();
            m_listeners.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_userData = br.ReadUInt64();
            des.ReadEmptyPointer(br);/* m_internal POINTER VOID */
            m_uid = br.ReadUInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteVoidPointer(bw);/* m_owner POINTER VOID */
            s.WriteClassPointer(bw, m_data);
            s.WriteClassPointer(bw, m_constraintModifiers);
            s.WriteClassPointerCStyleArray(bw, m_entities);//s.WriteClassPointer(bw, m_entities);
            s.WriteByte(bw, m_priority);
            bw.WriteBoolean(m_wantRuntime);
            s.WriteByte(bw, m_destructionRemapInfo);
            bw.Position += 5;
            m_listeners.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            bw.WriteUInt64(m_userData);
            s.WriteVoidPointer(bw);/* m_internal POINTER VOID */
            bw.WriteUInt32(m_uid);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

