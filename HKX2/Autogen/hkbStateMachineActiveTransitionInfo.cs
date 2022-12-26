using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbStateMachineActiveTransitionInfo Signatire: 0xbb90d54f size: 40 flags: FLAGS_NONE

    // m_transitionEffect m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 0 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_transitionEffectInternalStateInfo m_class: hkbNodeInternalStateInfo Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 8 flags:  enum: 
    // m_transitionInfoReference m_class: hkbStateMachineTransitionInfoReference Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_transitionInfoReferenceForTE m_class: hkbStateMachineTransitionInfoReference Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 22 flags:  enum: 
    // m_fromStateId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 28 flags:  enum: 
    // m_toStateId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_isReturnToPreviousState m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    
    public class hkbStateMachineActiveTransitionInfo : IHavokObject
    {

        public dynamic /* POINTER VOID */ m_transitionEffect;
        public hkbNodeInternalStateInfo /*pointer struct*/ m_transitionEffectInternalStateInfo;
        public hkbStateMachineTransitionInfoReference/*struct void*/ m_transitionInfoReference;
        public hkbStateMachineTransitionInfoReference/*struct void*/ m_transitionInfoReferenceForTE;
        public int m_fromStateId;
        public int m_toStateId;
        public bool m_isReturnToPreviousState;

        public uint Signature => 0xbb90d54f;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            des.ReadEmptyPointer(br);/* m_transitionEffect POINTER VOID */
            m_transitionEffectInternalStateInfo = des.ReadClassPointer<hkbNodeInternalStateInfo>(br);
            m_transitionInfoReference = new hkbStateMachineTransitionInfoReference();
            m_transitionInfoReference.Read(des,br);
            m_transitionInfoReferenceForTE = new hkbStateMachineTransitionInfoReference();
            m_transitionInfoReferenceForTE.Read(des,br);
            m_fromStateId = br.ReadInt32();
            m_toStateId = br.ReadInt32();
            m_isReturnToPreviousState = br.ReadBoolean();
            br.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteVoidPointer(bw);/* m_transitionEffect POINTER VOID */
            s.WriteClassPointer(bw, m_transitionEffectInternalStateInfo);
            m_transitionInfoReference.Write(s, bw);
            m_transitionInfoReferenceForTE.Write(s, bw);
            bw.WriteInt32(m_fromStateId);
            bw.WriteInt32(m_toStateId);
            bw.WriteBoolean(m_isReturnToPreviousState);
            bw.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

