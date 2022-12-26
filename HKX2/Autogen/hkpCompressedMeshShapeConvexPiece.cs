using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpCompressedMeshShapeConvexPiece Signatire: 0x385bb842 size: 80 flags: FLAGS_NONE

    // m_offset m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_vertices m_class:  Type.TYPE_ARRAY Type.TYPE_UINT16 arrSize: 0 offset: 16 flags:  enum: 
    // m_faceVertices m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 32 flags:  enum: 
    // m_faceOffsets m_class:  Type.TYPE_ARRAY Type.TYPE_UINT16 arrSize: 0 offset: 48 flags:  enum: 
    // m_reference m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_transformIndex m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 66 flags:  enum: 
    
    public class hkpCompressedMeshShapeConvexPiece : IHavokObject
    {

        public Vector4 m_offset;
        public List<ushort> m_vertices;
        public List<byte> m_faceVertices;
        public List<ushort> m_faceOffsets;
        public ushort m_reference;
        public ushort m_transformIndex;

        public uint Signature => 0x385bb842;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_offset = br.ReadVector4();
            m_vertices = des.ReadUInt16Array(br);
            m_faceVertices = des.ReadByteArray(br);
            m_faceOffsets = des.ReadUInt16Array(br);
            m_reference = br.ReadUInt16();
            m_transformIndex = br.ReadUInt16();
            br.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteVector4(m_offset);
            s.WriteUInt16Array(bw, m_vertices);
            s.WriteByteArray(bw, m_faceVertices);
            s.WriteUInt16Array(bw, m_faceOffsets);
            bw.WriteUInt16(m_reference);
            bw.WriteUInt16(m_transformIndex);
            bw.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

