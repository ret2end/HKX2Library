using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpEntitySpuCollisionCallback Signatire: 0x81147f05 size: 16 flags: FLAGS_NONE

    // m_util m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 0 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_capacity m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 8 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_eventFilter m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 10 flags:  enum: 
    // m_userFilter m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 11 flags:  enum: 
    
    public class hkpEntitySpuCollisionCallback : IHavokObject
    {

        public dynamic /* POINTER VOID */ m_util;
        public ushort m_capacity;
        public byte m_eventFilter;
        public byte m_userFilter;

        public uint Signature => 0x81147f05;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            des.ReadEmptyPointer(br);/* m_util POINTER VOID */
            m_capacity = br.ReadUInt16();
            m_eventFilter = br.ReadByte();
            m_userFilter = br.ReadByte();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteVoidPointer(bw);/* m_util POINTER VOID */
            bw.WriteUInt16(m_capacity);
            bw.WriteByte(m_eventFilter);
            bw.WriteByte(m_userFilter);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

