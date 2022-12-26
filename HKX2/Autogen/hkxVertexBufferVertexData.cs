using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxVertexBufferVertexData Signatire: 0xd72b6fd0 size: 104 flags: FLAGS_NONE

    // m_vectorData m_class:  Type.TYPE_ARRAY Type.TYPE_VECTOR4 arrSize: 0 offset: 0 flags:  enum: 
    // m_floatData m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 16 flags:  enum: 
    // m_uint32Data m_class:  Type.TYPE_ARRAY Type.TYPE_UINT32 arrSize: 0 offset: 32 flags:  enum: 
    // m_uint16Data m_class:  Type.TYPE_ARRAY Type.TYPE_UINT16 arrSize: 0 offset: 48 flags:  enum: 
    // m_uint8Data m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 64 flags:  enum: 
    // m_numVerts m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_vectorStride m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 84 flags:  enum: 
    // m_floatStride m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_uint32Stride m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 92 flags:  enum: 
    // m_uint16Stride m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_uint8Stride m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 100 flags:  enum: 
    
    public class hkxVertexBufferVertexData : IHavokObject
    {

        public List<Vector4> m_vectorData;
        public List<float> m_floatData;
        public List<uint> m_uint32Data;
        public List<ushort> m_uint16Data;
        public List<byte> m_uint8Data;
        public uint m_numVerts;
        public uint m_vectorStride;
        public uint m_floatStride;
        public uint m_uint32Stride;
        public uint m_uint16Stride;
        public uint m_uint8Stride;

        public uint Signature => 0xd72b6fd0;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_vectorData = des.ReadVector4Array(br);
            m_floatData = des.ReadSingleArray(br);
            m_uint32Data = des.ReadUInt32Array(br);
            m_uint16Data = des.ReadUInt16Array(br);
            m_uint8Data = des.ReadByteArray(br);
            m_numVerts = br.ReadUInt32();
            m_vectorStride = br.ReadUInt32();
            m_floatStride = br.ReadUInt32();
            m_uint32Stride = br.ReadUInt32();
            m_uint16Stride = br.ReadUInt32();
            m_uint8Stride = br.ReadUInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteVector4Array(bw, m_vectorData);
            s.WriteSingleArray(bw, m_floatData);
            s.WriteUInt32Array(bw, m_uint32Data);
            s.WriteUInt16Array(bw, m_uint16Data);
            s.WriteByteArray(bw, m_uint8Data);
            bw.WriteUInt32(m_numVerts);
            bw.WriteUInt32(m_vectorStride);
            bw.WriteUInt32(m_floatStride);
            bw.WriteUInt32(m_uint32Stride);
            bw.WriteUInt32(m_uint16Stride);
            bw.WriteUInt32(m_uint8Stride);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

