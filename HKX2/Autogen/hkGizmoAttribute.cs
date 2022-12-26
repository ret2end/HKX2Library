using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkGizmoAttribute Signatire: 0x23aadfb6 size: 24 flags: FLAGS_NONE

    // m_visible m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_label m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 16 flags:  enum: GizmoType
    
    public class hkGizmoAttribute : IHavokObject
    {

        public bool m_visible;
        public string m_label;
        public sbyte m_type;

        public uint Signature => 0x23aadfb6;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_visible = br.ReadBoolean();
            br.Position += 7;
            m_label = des.ReadStringPointer(br);//m_label = br.ReadASCII();
            m_type = br.ReadSByte();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteBoolean(m_visible);
            bw.Position += 7;
            s.WriteStringPointer(bw, m_label);//bw.WriteASCII(m_label, true);
            s.WriteSByte(bw, m_type);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

