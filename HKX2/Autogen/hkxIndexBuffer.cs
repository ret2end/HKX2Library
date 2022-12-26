using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxIndexBuffer Signatire: 0xc12c8197 size: 64 flags: FLAGS_NONE

    // m_indexType m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 16 flags:  enum: IndexType
    // m_indices16 m_class:  Type.TYPE_ARRAY Type.TYPE_UINT16 arrSize: 0 offset: 24 flags:  enum: 
    // m_indices32 m_class:  Type.TYPE_ARRAY Type.TYPE_UINT32 arrSize: 0 offset: 40 flags:  enum: 
    // m_vertexBaseOffset m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 56 flags:  enum: 
    // m_length m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 60 flags:  enum: 
    
    public class hkxIndexBuffer : hkReferencedObject
    {

        public sbyte m_indexType;
        public List<ushort> m_indices16;
        public List<uint> m_indices32;
        public uint m_vertexBaseOffset;
        public uint m_length;

        public override uint Signature => 0xc12c8197;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_indexType = br.ReadSByte();
            br.Position += 7;
            m_indices16 = des.ReadUInt16Array(br);
            m_indices32 = des.ReadUInt32Array(br);
            m_vertexBaseOffset = br.ReadUInt32();
            m_length = br.ReadUInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteSByte(bw, m_indexType);
            bw.Position += 7;
            s.WriteUInt16Array(bw, m_indices16);
            s.WriteUInt32Array(bw, m_indices32);
            bw.WriteUInt32(m_vertexBaseOffset);
            bw.WriteUInt32(m_length);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

