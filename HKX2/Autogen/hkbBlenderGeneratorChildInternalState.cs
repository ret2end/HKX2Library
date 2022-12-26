using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbBlenderGeneratorChildInternalState Signatire: 0xff7327c0 size: 2 flags: FLAGS_NONE

    // m_isActive m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_syncNextFrame m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 1 flags:  enum: 
    
    public class hkbBlenderGeneratorChildInternalState : IHavokObject
    {

        public bool m_isActive;
        public bool m_syncNextFrame;

        public uint Signature => 0xff7327c0;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_isActive = br.ReadBoolean();
            m_syncNextFrame = br.ReadBoolean();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteBoolean(m_isActive);
            bw.WriteBoolean(m_syncNextFrame);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

