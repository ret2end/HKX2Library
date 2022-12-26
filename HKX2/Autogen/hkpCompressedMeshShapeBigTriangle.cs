using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpCompressedMeshShapeBigTriangle Signatire: 0xcbfc95a4 size: 16 flags: FLAGS_NONE

    // m_a m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_b m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    // m_c m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_material m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_weldingInfo m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    // m_transformIndex m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 14 flags:  enum: 
    
    public class hkpCompressedMeshShapeBigTriangle : IHavokObject
    {

        public ushort m_a;
        public ushort m_b;
        public ushort m_c;
        public uint m_material;
        public ushort m_weldingInfo;
        public ushort m_transformIndex;

        public uint Signature => 0xcbfc95a4;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_a = br.ReadUInt16();
            m_b = br.ReadUInt16();
            m_c = br.ReadUInt16();
            br.Position += 2;
            m_material = br.ReadUInt32();
            m_weldingInfo = br.ReadUInt16();
            m_transformIndex = br.ReadUInt16();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteUInt16(m_a);
            bw.WriteUInt16(m_b);
            bw.WriteUInt16(m_c);
            bw.Position += 2;
            bw.WriteUInt32(m_material);
            bw.WriteUInt16(m_weldingInfo);
            bw.WriteUInt16(m_transformIndex);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

