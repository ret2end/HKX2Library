using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpMoppCodeReindexedTerminal Signatire: 0x6ed8ac06 size: 8 flags: FLAGS_NONE

    // m_origShapeKey m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_reindexedShapeKey m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    
    public class hkpMoppCodeReindexedTerminal : IHavokObject
    {

        public uint m_origShapeKey;
        public uint m_reindexedShapeKey;

        public uint Signature => 0x6ed8ac06;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_origShapeKey = br.ReadUInt32();
            m_reindexedShapeKey = br.ReadUInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteUInt32(m_origShapeKey);
            bw.WriteUInt32(m_reindexedShapeKey);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

