using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpAgent1nSector Signatire: 0x626e55a size: 512 flags: FLAGS_NONE

    // m_bytesAllocated m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_pad0 m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_pad1 m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_pad2 m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    // m_data m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 496 offset: 16 flags:  enum: 

    public class hkpAgent1nSector : IHavokObject
    {

        public uint m_bytesAllocated;
        public uint m_pad0;
        public uint m_pad1;
        public uint m_pad2;
        public List<byte> m_data;

        public uint Signature => 0x626e55a;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_bytesAllocated = br.ReadUInt32();
            m_pad0 = br.ReadUInt32();
            m_pad1 = br.ReadUInt32();
            m_pad2 = br.ReadUInt32();
            m_data = des.ReadByteCStyleArray(br, 496);//m_data = br.ReadByte();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteUInt32(m_bytesAllocated);
            bw.WriteUInt32(m_pad0);
            bw.WriteUInt32(m_pad1);
            bw.WriteUInt32(m_pad2);
            s.WriteByteCStyleArray(bw, m_data);//bw.WriteByte(m_data);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

