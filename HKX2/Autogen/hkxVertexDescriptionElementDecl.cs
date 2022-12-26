using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxVertexDescriptionElementDecl Signatire: 0x483a429b size: 16 flags: FLAGS_NONE

    // m_byteOffset m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_UINT16 arrSize: 0 offset: 4 flags:  enum: DataType
    // m_usage m_class:  Type.TYPE_ENUM Type.TYPE_UINT16 arrSize: 0 offset: 6 flags:  enum: DataUsage
    // m_byteStride m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_numElements m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    
    public class hkxVertexDescriptionElementDecl : IHavokObject
    {

        public uint m_byteOffset;
        public ushort m_type;
        public ushort m_usage;
        public uint m_byteStride;
        public byte m_numElements;

        public uint Signature => 0x483a429b;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_byteOffset = br.ReadUInt32();
            m_type = br.ReadUInt16();
            m_usage = br.ReadUInt16();
            m_byteStride = br.ReadUInt32();
            m_numElements = br.ReadByte();
            br.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteUInt32(m_byteOffset);
            s.WriteUInt16(bw, m_type);
            s.WriteUInt16(bw, m_usage);
            bw.WriteUInt32(m_byteStride);
            bw.WriteByte(m_numElements);
            bw.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

