using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSIStateManagerModifierBSiStateData Signatire: 0x6b8a15fc size: 16 flags: FLAGS_NONE

    // m_pStateMachine m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 0 flags:  enum: 
    // m_StateID m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_iStateToSetAs m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    
    public class BSIStateManagerModifierBSiStateData : IHavokObject
    {

        public hkbGenerator /*pointer struct*/ m_pStateMachine;
        public int m_StateID;
        public int m_iStateToSetAs;

        public uint Signature => 0x6b8a15fc;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_pStateMachine = des.ReadClassPointer<hkbGenerator>(br);
            m_StateID = br.ReadInt32();
            m_iStateToSetAs = br.ReadInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteClassPointer(bw, m_pStateMachine);
            bw.WriteInt32(m_StateID);
            bw.WriteInt32(m_iStateToSetAs);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

