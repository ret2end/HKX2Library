using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpWorldObject Signatire: 0x49fb6f2e size: 208 flags: FLAGS_NONE

    // m_world m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 16 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_userData m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_collidable m_class: hkpLinkedCollidable Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_multiThreadCheck m_class: hkMultiThreadCheck Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 160 flags:  enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 176 flags:  enum: 
    // m_properties m_class: hkpProperty Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 184 flags:  enum: 
    // m_treeData m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 200 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpWorldObject : hkReferencedObject
    {

        public dynamic /* POINTER VOID */ m_world;
        public ulong m_userData;
        public hkpLinkedCollidable/*struct void*/ m_collidable;
        public hkMultiThreadCheck/*struct void*/ m_multiThreadCheck;
        public string m_name;
        public List<hkpProperty> m_properties;
        public dynamic /* POINTER VOID */ m_treeData;

        public override uint Signature => 0x49fb6f2e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            des.ReadEmptyPointer(br);/* m_world POINTER VOID */
            m_userData = br.ReadUInt64();
            m_collidable = new hkpLinkedCollidable();
            m_collidable.Read(des,br);
            m_multiThreadCheck = new hkMultiThreadCheck();
            m_multiThreadCheck.Read(des,br);
            br.Position += 4;
            m_name = des.ReadStringPointer(br);
            m_properties = des.ReadClassArray<hkpProperty>(br);
            des.ReadEmptyPointer(br);/* m_treeData POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteVoidPointer(bw);/* m_world POINTER VOID */
            bw.WriteUInt64(m_userData);
            m_collidable.Write(s, bw);
            m_multiThreadCheck.Write(s, bw);
            bw.Position += 4;
            s.WriteStringPointer(bw, m_name);
            s.WriteClassArray<hkpProperty>(bw, m_properties);
            s.WriteVoidPointer(bw);/* m_treeData POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

