using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbAttributeModifierAssignment Signatire: 0x48b8ad52 size: 8 flags: FLAGS_NONE

    // m_attributeIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_attributeValue m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    
    public class hkbAttributeModifierAssignment : IHavokObject
    {

        public int m_attributeIndex;
        public float m_attributeValue;

        public uint Signature => 0x48b8ad52;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_attributeIndex = br.ReadInt32();
            m_attributeValue = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteInt32(m_attributeIndex);
            bw.WriteSingle(m_attributeValue);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

