using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkAabbUint32 Signatire: 0x11e7c11 size: 32 flags: FLAGS_NONE

    // m_min m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 3 offset: 0 flags: ALIGN_8|FLAGS_NONE enum: 
    // m_expansionMin m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 3 offset: 12 flags:  enum: 
    // m_expansionShift m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 15 flags:  enum: 
    // m_max m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 3 offset: 16 flags:  enum: 
    // m_expansionMax m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 3 offset: 28 flags:  enum: 
    // m_shapeKeyByte m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 31 flags:  enum: 

    public class hkAabbUint32 : IHavokObject
    {

        public List<uint> m_min;
        public List<byte> m_expansionMin;
        public byte m_expansionShift;
        public List<uint> m_max;
        public List<byte> m_expansionMax;
        public byte m_shapeKeyByte;

        public uint Signature => 0x11e7c11;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_min = des.ReadUInt32CStyleArray(br, 3);//m_min = br.ReadUInt32();
            m_expansionMin = des.ReadByteCStyleArray(br, 3);//m_expansionMin = br.ReadByte();
            m_expansionShift = br.ReadByte();
            m_max = des.ReadUInt32CStyleArray(br, 3);//m_max = br.ReadUInt32();
            m_expansionMax = des.ReadByteCStyleArray(br, 3);//m_expansionMax = br.ReadByte();
            m_shapeKeyByte = br.ReadByte();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteUInt32CStyleArray(bw, m_min);//bw.WriteUInt32(m_min);
            s.WriteByteCStyleArray(bw, m_expansionMin);//bw.WriteByte(m_expansionMin);
            bw.WriteByte(m_expansionShift);
            s.WriteUInt32CStyleArray(bw, m_max);//bw.WriteUInt32(m_max);
            s.WriteByteCStyleArray(bw, m_expansionMax);//bw.WriteByte(m_expansionMax);
            bw.WriteByte(m_shapeKeyByte);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

