using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbVariableBindingSet Signatire: 0x338ad4ff size: 40 flags: FLAGS_NONE

    // m_bindings m_class: hkbVariableBindingSetBinding Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    // m_indexOfBindingToEnable m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_hasOutputBinding m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 36 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbVariableBindingSet : hkReferencedObject
    {

        public List<hkbVariableBindingSetBinding> m_bindings;
        public int m_indexOfBindingToEnable;
        public bool m_hasOutputBinding;

        public override uint Signature => 0x338ad4ff;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_bindings = des.ReadClassArray<hkbVariableBindingSetBinding>(br);
            m_indexOfBindingToEnable = br.ReadInt32();
            m_hasOutputBinding = br.ReadBoolean();
            br.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkbVariableBindingSetBinding>(bw, m_bindings);
            bw.WriteInt32(m_indexOfBindingToEnable);
            bw.WriteBoolean(m_hasOutputBinding);
            bw.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

