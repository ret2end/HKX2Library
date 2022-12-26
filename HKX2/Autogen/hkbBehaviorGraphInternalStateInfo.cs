using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbBehaviorGraphInternalStateInfo Signatire: 0x645f898b size: 80 flags: FLAGS_NONE

    // m_characterId m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_internalState m_class: hkbBehaviorGraphInternalState Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags:  enum: 
    // m_auxiliaryNodeInfo m_class: hkbAuxiliaryNodeInfo Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 32 flags:  enum: 
    // m_activeEventIds m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 48 flags:  enum: 
    // m_activeVariableIds m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 64 flags:  enum: 
    
    public class hkbBehaviorGraphInternalStateInfo : hkReferencedObject
    {

        public ulong m_characterId;
        public hkbBehaviorGraphInternalState /*pointer struct*/ m_internalState;
        public List<hkbAuxiliaryNodeInfo> m_auxiliaryNodeInfo;
        public List<short> m_activeEventIds;
        public List<short> m_activeVariableIds;

        public override uint Signature => 0x645f898b;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_characterId = br.ReadUInt64();
            m_internalState = des.ReadClassPointer<hkbBehaviorGraphInternalState>(br);
            m_auxiliaryNodeInfo = des.ReadClassPointerArray<hkbAuxiliaryNodeInfo>(br);
            m_activeEventIds = des.ReadInt16Array(br);
            m_activeVariableIds = des.ReadInt16Array(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteUInt64(m_characterId);
            s.WriteClassPointer(bw, m_internalState);
            s.WriteClassPointerArray<hkbAuxiliaryNodeInfo>(bw, m_auxiliaryNodeInfo);
            s.WriteInt16Array(bw, m_activeEventIds);
            s.WriteInt16Array(bw, m_activeVariableIds);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

