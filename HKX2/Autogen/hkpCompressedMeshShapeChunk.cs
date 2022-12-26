using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpCompressedMeshShapeChunk Signatire: 0x5d0d67bd size: 96 flags: FLAGS_NONE

    // m_offset m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_vertices m_class:  Type.TYPE_ARRAY Type.TYPE_UINT16 arrSize: 0 offset: 16 flags:  enum: 
    // m_indices m_class:  Type.TYPE_ARRAY Type.TYPE_UINT16 arrSize: 0 offset: 32 flags:  enum: 
    // m_stripLengths m_class:  Type.TYPE_ARRAY Type.TYPE_UINT16 arrSize: 0 offset: 48 flags:  enum: 
    // m_weldingInfo m_class:  Type.TYPE_ARRAY Type.TYPE_UINT16 arrSize: 0 offset: 64 flags:  enum: 
    // m_materialInfo m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_reference m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 84 flags:  enum: 
    // m_transformIndex m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 86 flags:  enum: 
    
    public class hkpCompressedMeshShapeChunk : IHavokObject
    {

        public Vector4 m_offset;
        public List<ushort> m_vertices;
        public List<ushort> m_indices;
        public List<ushort> m_stripLengths;
        public List<ushort> m_weldingInfo;
        public uint m_materialInfo;
        public ushort m_reference;
        public ushort m_transformIndex;

        public uint Signature => 0x5d0d67bd;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_offset = br.ReadVector4();
            m_vertices = des.ReadUInt16Array(br);
            m_indices = des.ReadUInt16Array(br);
            m_stripLengths = des.ReadUInt16Array(br);
            m_weldingInfo = des.ReadUInt16Array(br);
            m_materialInfo = br.ReadUInt32();
            m_reference = br.ReadUInt16();
            m_transformIndex = br.ReadUInt16();
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteVector4(m_offset);
            s.WriteUInt16Array(bw, m_vertices);
            s.WriteUInt16Array(bw, m_indices);
            s.WriteUInt16Array(bw, m_stripLengths);
            s.WriteUInt16Array(bw, m_weldingInfo);
            bw.WriteUInt32(m_materialInfo);
            bw.WriteUInt16(m_reference);
            bw.WriteUInt16(m_transformIndex);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

