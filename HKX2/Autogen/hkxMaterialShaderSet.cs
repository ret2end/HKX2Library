using System.Collections.Generic;

namespace HKX2
{
    public class hkxMaterialShaderSet : hkReferencedObject
    {
        public List<hkxMaterialShader> m_shaders;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_shaders = des.ReadClassPointerArray<hkxMaterialShader>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_shaders);
        }
    }
}