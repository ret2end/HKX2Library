using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkUiAttribute Signatire: 0xeb6e96e3 size: 40 flags: FLAGS_NONE

    // m_visible m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_hideInModeler m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 1 flags:  enum: HideInModeler
    // m_label m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_group m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_hideBaseClassMembers m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_endGroup m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_endGroup2 m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 33 flags:  enum: 
    // m_advanced m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 34 flags:  enum: 

    public class hkUiAttribute : IHavokObject
    {

        public bool m_visible;
        public sbyte m_hideInModeler;
        public string m_label;
        public string m_group;
        public string m_hideBaseClassMembers;
        public bool m_endGroup;
        public bool m_endGroup2;
        public bool m_advanced;

        public uint Signature => 0xeb6e96e3;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_visible = br.ReadBoolean();
            m_hideInModeler = br.ReadSByte();
            br.Position += 6;
            m_label = des.ReadStringPointer(br);//m_label = br.ReadASCII();
            m_group = des.ReadStringPointer(br);//m_group = br.ReadASCII();
            m_hideBaseClassMembers = des.ReadStringPointer(br);//m_hideBaseClassMembers = br.ReadASCII();
            m_endGroup = br.ReadBoolean();
            m_endGroup2 = br.ReadBoolean();
            m_advanced = br.ReadBoolean();
            br.Position += 5;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteBoolean(m_visible);
            s.WriteSByte(bw, m_hideInModeler);
            bw.Position += 6;
            s.WriteStringPointer(bw, m_label);//bw.WriteASCII(m_label, true);
            s.WriteStringPointer(bw, m_group);//bw.WriteASCII(m_group, true);
            s.WriteStringPointer(bw, m_hideBaseClassMembers);//bw.WriteASCII(m_hideBaseClassMembers, true);
            bw.WriteBoolean(m_endGroup);
            bw.WriteBoolean(m_endGroup2);
            bw.WriteBoolean(m_advanced);
            bw.Position += 5;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

