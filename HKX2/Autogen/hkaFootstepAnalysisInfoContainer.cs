using System.Collections.Generic;

namespace HKX2
{
    public class hkaFootstepAnalysisInfoContainer : hkReferencedObject
    {
        public List<hkaFootstepAnalysisInfo> m_previewInfo;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_previewInfo = des.ReadClassPointerArray<hkaFootstepAnalysisInfo>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_previewInfo);
        }
    }
}