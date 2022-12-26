using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbBindable Signatire: 0x2c1432d7 size: 48 flags: FLAGS_NONE

    // m_variableBindingSet m_class: hkbVariableBindingSet Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    // m_cachedBindables m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 24 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_areBindablesCached m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 40 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbBindable : hkReferencedObject
    {

        public hkbVariableBindingSet /*pointer struct*/ m_variableBindingSet;
        public List<ulong> m_cachedBindables;
        public bool m_areBindablesCached;

        public override uint Signature => 0x2c1432d7;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_variableBindingSet = des.ReadClassPointer<hkbVariableBindingSet>(br);
            des.ReadEmptyArray(br); //m_cachedBindables
            m_areBindablesCached = br.ReadBoolean();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_variableBindingSet);
            s.WriteVoidArray(bw); // m_cachedBindables
            bw.WriteBoolean(m_areBindablesCached);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

