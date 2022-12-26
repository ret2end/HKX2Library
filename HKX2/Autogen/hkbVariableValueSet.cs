using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbVariableValueSet Signatire: 0x27812d8d size: 64 flags: FLAGS_NONE

    // m_wordVariableValues m_class: hkbVariableValue Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    // m_quadVariableValues m_class:  Type.TYPE_ARRAY Type.TYPE_VECTOR4 arrSize: 0 offset: 32 flags:  enum: 
    // m_variantVariableValues m_class: hkReferencedObject Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 48 flags:  enum: 
    
    public class hkbVariableValueSet : hkReferencedObject
    {

        public List<hkbVariableValue> m_wordVariableValues;
        public List<Vector4> m_quadVariableValues;
        public List<hkReferencedObject> m_variantVariableValues;

        public override uint Signature => 0x27812d8d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_wordVariableValues = des.ReadClassArray<hkbVariableValue>(br);
            m_quadVariableValues = des.ReadVector4Array(br);
            m_variantVariableValues = des.ReadClassPointerArray<hkReferencedObject>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkbVariableValue>(bw, m_wordVariableValues);
            s.WriteVector4Array(bw, m_quadVariableValues);
            s.WriteClassPointerArray<hkReferencedObject>(bw, m_variantVariableValues);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

