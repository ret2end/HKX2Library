using System.Collections.Generic;

namespace HKX2
{
    public class hclClothSetupContainer : hkReferencedObject
    {
        public List<hclClothSetupObject> m_clothSetupDatas;
        public List<hclNamedSetupMesh> m_namedSetupMeshWrappers;
        public List<hclNamedTransformSetSetupObject> m_namedTransformSetWrappers;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_clothSetupDatas = des.ReadClassPointerArray<hclClothSetupObject>(br);
            m_namedSetupMeshWrappers = des.ReadClassPointerArray<hclNamedSetupMesh>(br);
            m_namedTransformSetWrappers = des.ReadClassPointerArray<hclNamedTransformSetSetupObject>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_clothSetupDatas);
            s.WriteClassPointerArray(bw, m_namedSetupMeshWrappers);
            s.WriteClassPointerArray(bw, m_namedTransformSetWrappers);
        }
    }
}