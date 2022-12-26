using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbBehaviorGraphInternalState Signatire: 0x8699b6eb size: 40 flags: FLAGS_NONE

    // m_nodeInternalStateInfos m_class: hkbNodeInternalStateInfo Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags:  enum: 
    // m_variableValueSet m_class: hkbVariableValueSet Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkbBehaviorGraphInternalState : hkReferencedObject
    {

        public List<hkbNodeInternalStateInfo> m_nodeInternalStateInfos;
        public hkbVariableValueSet /*pointer struct*/ m_variableValueSet;

        public override uint Signature => 0x8699b6eb;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_nodeInternalStateInfos = des.ReadClassPointerArray<hkbNodeInternalStateInfo>(br);
            m_variableValueSet = des.ReadClassPointer<hkbVariableValueSet>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkbNodeInternalStateInfo>(bw, m_nodeInternalStateInfos);
            s.WriteClassPointer(bw, m_variableValueSet);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

