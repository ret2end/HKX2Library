using System.Collections.Generic;

namespace HKX2
{
    public class hkxVertexBufferVertexData : IHavokObject
    {
        public List<uint> m_floatData;
        public uint m_floatStride;
        public uint m_numVerts;
        public List<ushort> m_uint16Data;
        public uint m_uint16Stride;
        public List<uint> m_uint32Data;
        public uint m_uint32Stride;
        public List<byte> m_uint8Data;
        public uint m_uint8Stride;

        public List<uint> m_vectorData;
        public uint m_vectorStride;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_vectorData = des.ReadUInt32Array(br);
            m_floatData = des.ReadUInt32Array(br);
            m_uint32Data = des.ReadUInt32Array(br);
            m_uint16Data = des.ReadUInt16Array(br);
            m_uint8Data = des.ReadByteArray(br);
            m_numVerts = br.ReadUInt32();
            m_vectorStride = br.ReadUInt32();
            m_floatStride = br.ReadUInt32();
            m_uint32Stride = br.ReadUInt32();
            m_uint16Stride = br.ReadUInt32();
            m_uint8Stride = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteUInt32Array(bw, m_vectorData);
            s.WriteUInt32Array(bw, m_floatData);
            s.WriteUInt32Array(bw, m_uint32Data);
            s.WriteUInt16Array(bw, m_uint16Data);
            s.WriteByteArray(bw, m_uint8Data);
            bw.WriteUInt32(m_numVerts);
            bw.WriteUInt32(m_vectorStride);
            bw.WriteUInt32(m_floatStride);
            bw.WriteUInt32(m_uint32Stride);
            bw.WriteUInt32(m_uint16Stride);
            bw.WriteUInt32(m_uint8Stride);
        }
    }
}