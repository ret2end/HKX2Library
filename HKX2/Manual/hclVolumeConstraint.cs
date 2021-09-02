using System.Collections.Generic;

namespace HKX2
{
    public class hclVolumeConstraint : hclConstraintSet
    {
        public List<hclVolumeConstraintApplyData> m_applyDatas;

        public List<hclVolumeConstraintFrameData> m_frameDatas;
        public override uint Signature => 0x5478425E;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_frameDatas = des.ReadClassArray<hclVolumeConstraintFrameData>(br);
            m_applyDatas = des.ReadClassArray<hclVolumeConstraintApplyData>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_frameDatas);
            s.WriteClassArray(bw, m_applyDatas);
        }
    }
}