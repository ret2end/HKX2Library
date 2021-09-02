using System.Collections.Generic;

namespace HKX2
{
    public class hkaiAvoidancePairProperties : hkReferencedObject
    {
        public List<hkaiAvoidancePairPropertiesPairData> m_avoidancePairDataMap;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_avoidancePairDataMap = des.ReadClassArray<hkaiAvoidancePairPropertiesPairData>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_avoidancePairDataMap);
        }
    }
}