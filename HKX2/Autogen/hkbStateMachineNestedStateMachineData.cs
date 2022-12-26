using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbStateMachineNestedStateMachineData Signatire: 0x7358f5da size: 16 flags: FLAGS_NONE

    // m_nestedStateMachine m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 0 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_eventIdMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 8 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbStateMachineNestedStateMachineData : IHavokObject
    {

        public dynamic /* POINTER VOID */ m_nestedStateMachine;
        public dynamic /* POINTER VOID */ m_eventIdMap;

        public uint Signature => 0x7358f5da;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            des.ReadEmptyPointer(br);/* m_nestedStateMachine POINTER VOID */
            des.ReadEmptyPointer(br);/* m_eventIdMap POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteVoidPointer(bw);/* m_nestedStateMachine POINTER VOID */
            s.WriteVoidPointer(bw);/* m_eventIdMap POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

