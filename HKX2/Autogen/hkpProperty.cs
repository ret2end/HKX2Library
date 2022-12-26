using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpProperty Signatire: 0x9ce308e9 size: 16 flags: FLAGS_NONE

    // m_key m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_alignmentPadding m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_value m_class: hkpPropertyValue Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkpProperty : IHavokObject
    {

        public uint m_key;
        public uint m_alignmentPadding;
        public hkpPropertyValue/*struct void*/ m_value;

        public uint Signature => 0x9ce308e9;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_key = br.ReadUInt32();
            m_alignmentPadding = br.ReadUInt32();
            m_value = new hkpPropertyValue();
            m_value.Read(des,br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteUInt32(m_key);
            bw.WriteUInt32(m_alignmentPadding);
            m_value.Write(s, bw);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

