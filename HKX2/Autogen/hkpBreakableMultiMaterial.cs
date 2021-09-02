using System.Collections.Generic;

namespace HKX2
{
    public class hkpBreakableMultiMaterial : hkpBreakableMaterial
    {
        public hkpBreakableMultiMaterialInverseMapping m_inverseMapping;

        public List<hkpBreakableMaterial> m_subMaterials;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_subMaterials = des.ReadClassPointerArray<hkpBreakableMaterial>(br);
            m_inverseMapping = des.ReadClassPointer<hkpBreakableMultiMaterialInverseMapping>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_subMaterials);
            s.WriteClassPointer(bw, m_inverseMapping);
        }
    }
}