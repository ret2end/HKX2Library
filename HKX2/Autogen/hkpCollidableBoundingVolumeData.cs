using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpCollidableBoundingVolumeData Signatire: 0xb5f0e6b1 size: 56 flags: FLAGS_NONE

    // m_min m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 3 offset: 0 flags:  enum: 
    // m_expansionMin m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 3 offset: 12 flags:  enum: 
    // m_expansionShift m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 15 flags:  enum: 
    // m_max m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 3 offset: 16 flags:  enum: 
    // m_expansionMax m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 3 offset: 28 flags:  enum: 
    // m_padding m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 31 flags:  enum: 
    // m_numChildShapeAabbs m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 32 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_capacityChildShapeAabbs m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 34 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_childShapeAabbs m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 40 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_childShapeKeys m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 48 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 

    public class hkpCollidableBoundingVolumeData : IHavokObject
    {

        public List<uint> m_min;
        public List<byte> m_expansionMin;
        public byte m_expansionShift;
        public List<uint> m_max;
        public List<byte> m_expansionMax;
        public byte m_padding;
        public ushort m_numChildShapeAabbs;
        public ushort m_capacityChildShapeAabbs;
        public dynamic /* POINTER VOID */ m_childShapeAabbs;
        public dynamic /* POINTER VOID */ m_childShapeKeys;

        public uint Signature => 0xb5f0e6b1;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_min = des.ReadUInt32CStyleArray(br, 3);//m_min = br.ReadUInt32();
            m_expansionMin = des.ReadByteCStyleArray(br, 3);//m_expansionMin = br.ReadByte();
            m_expansionShift = br.ReadByte();
            m_max = des.ReadUInt32CStyleArray(br, 3);//m_max = br.ReadUInt32();
            m_expansionMax = des.ReadByteCStyleArray(br, 3);//m_expansionMax = br.ReadByte();
            m_padding = br.ReadByte();
            m_numChildShapeAabbs = br.ReadUInt16();
            m_capacityChildShapeAabbs = br.ReadUInt16();
            br.Position += 4;
            des.ReadEmptyPointer(br);/* m_childShapeAabbs POINTER VOID */
            des.ReadEmptyPointer(br);/* m_childShapeKeys POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteUInt32CStyleArray(bw, m_min);//bw.WriteUInt32(m_min);
            s.WriteByteCStyleArray(bw, m_expansionMin);//bw.WriteByte(m_expansionMin);
            bw.WriteByte(m_expansionShift);
            s.WriteUInt32CStyleArray(bw, m_max);//bw.WriteUInt32(m_max);
            s.WriteByteCStyleArray(bw, m_expansionMax);//bw.WriteByte(m_expansionMax);
            bw.WriteByte(m_padding);
            bw.WriteUInt16(m_numChildShapeAabbs);
            bw.WriteUInt16(m_capacityChildShapeAabbs);
            bw.Position += 4;
            s.WriteVoidPointer(bw);/* m_childShapeAabbs POINTER VOID */
            s.WriteVoidPointer(bw);/* m_childShapeKeys POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }
    }
}
