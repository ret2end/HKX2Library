using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxMaterialShaderSet Signatire: 0x154650f3 size: 32 flags: FLAGS_NONE

    // m_shaders m_class: hkxMaterialShader Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkxMaterialShaderSet : hkReferencedObject
    {

        public List<hkxMaterialShader> m_shaders;

        public override uint Signature => 0x154650f3;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_shaders = des.ReadClassPointerArray<hkxMaterialShader>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkxMaterialShader>(bw, m_shaders);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

