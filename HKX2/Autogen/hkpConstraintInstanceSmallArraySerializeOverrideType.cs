using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConstraintInstanceSmallArraySerializeOverrideType Signatire: 0xee3c2aec size: 16 flags: FLAGS_NONE

    // m_data m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 0 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_size m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_capacityAndFlags m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 10 flags:  enum: 
    
    public class hkpConstraintInstanceSmallArraySerializeOverrideType : IHavokObject
    {

        public dynamic /* POINTER VOID */ m_data;
        public ushort m_size;
        public ushort m_capacityAndFlags;

        public uint Signature => 0xee3c2aec;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            des.ReadEmptyPointer(br);/* m_data POINTER VOID */
            m_size = br.ReadUInt16();
            m_capacityAndFlags = br.ReadUInt16();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteVoidPointer(bw);/* m_data POINTER VOID */
            bw.WriteUInt16(m_size);
            bw.WriteUInt16(m_capacityAndFlags);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

