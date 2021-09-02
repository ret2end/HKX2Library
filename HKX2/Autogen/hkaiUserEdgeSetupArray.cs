using System.Collections.Generic;

namespace HKX2
{
    public class hkaiUserEdgeSetupArray : hkReferencedObject
    {
        public List<hkaiUserEdgeUtilsUserEdgeSetup> m_edgeSetups;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_edgeSetups = des.ReadClassArray<hkaiUserEdgeUtilsUserEdgeSetup>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_edgeSetups);
        }
    }
}