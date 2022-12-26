using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbStateMachineTransitionInfoReference Signatire: 0x9810c2d0 size: 6 flags: FLAGS_NONE

    // m_fromStateIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_transitionIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    // m_stateMachineId m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    
    public class hkbStateMachineTransitionInfoReference : IHavokObject
    {

        public short m_fromStateIndex;
        public short m_transitionIndex;
        public short m_stateMachineId;

        public uint Signature => 0x9810c2d0;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_fromStateIndex = br.ReadInt16();
            m_transitionIndex = br.ReadInt16();
            m_stateMachineId = br.ReadInt16();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteInt16(m_fromStateIndex);
            bw.WriteInt16(m_transitionIndex);
            bw.WriteInt16(m_stateMachineId);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

