using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPoweredChainMapperTarget Signatire: 0xf651c74d size: 16 flags: FLAGS_NONE

    // m_chain m_class: hkpPoweredChainData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 0 flags:  enum: 
    // m_infoIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkpPoweredChainMapperTarget : IHavokObject
    {

        public hkpPoweredChainData /*pointer struct*/ m_chain;
        public int m_infoIndex;

        public uint Signature => 0xf651c74d;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_chain = des.ReadClassPointer<hkpPoweredChainData>(br);
            m_infoIndex = br.ReadInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteClassPointer(bw, m_chain);
            bw.WriteInt32(m_infoIndex);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

