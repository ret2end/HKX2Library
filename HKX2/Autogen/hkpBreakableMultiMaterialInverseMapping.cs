using System.Collections.Generic;

namespace HKX2
{
    public class hkpBreakableMultiMaterialInverseMapping : hkReferencedObject
    {
        public List<hkpBreakableMultiMaterialInverseMappingDescriptor> m_descriptors;
        public List<uint> m_subShapeIds;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_descriptors = des.ReadClassArray<hkpBreakableMultiMaterialInverseMappingDescriptor>(br);
            m_subShapeIds = des.ReadUInt32Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_descriptors);
            s.WriteUInt32Array(bw, m_subShapeIds);
        }
    }
}