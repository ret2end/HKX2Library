using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpFirstPersonGun Signatire: 0x852ab70b size: 56 flags: FLAGS_NONE

    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 16 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_keyboardKey m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 32 flags:  enum: KeyboardKey
    // m_listeners m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 40 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpFirstPersonGun : hkReferencedObject
    {

        public byte m_type;
        public string m_name;
        public byte m_keyboardKey;
        //public List<> m_listeners;

        public override uint Signature => 0x852ab70b;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_type = br.ReadByte();
            br.Position += 7;
            m_name = des.ReadStringPointer(br);
            m_keyboardKey = br.ReadByte();
            br.Position += 7;
            des.ReadEmptyArray(br); //m_listeners = des.ReadClassPointerArray<>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteByte(bw, m_type);
            bw.Position += 7;
            s.WriteStringPointer(bw, m_name);
            s.WriteByte(bw, m_keyboardKey);
            bw.Position += 7;
            s.WriteVoidArray(bw);//s.WriteClassPointerArray<>(bw, m_listeners);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

