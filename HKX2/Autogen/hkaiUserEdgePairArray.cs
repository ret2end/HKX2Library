using System.Collections.Generic;

namespace HKX2
{
    public class hkaiUserEdgePairArray : hkReferencedObject
    {
        public List<hkaiUserEdgeUtilsUserEdgePair> m_edgePairs;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_edgePairs = des.ReadClassArray<hkaiUserEdgeUtilsUserEdgePair>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_edgePairs);
        }
    }
}