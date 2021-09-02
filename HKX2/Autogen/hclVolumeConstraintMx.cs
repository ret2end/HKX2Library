using System.Collections.Generic;

namespace HKX2
{
    public class hclVolumeConstraintMx : hclConstraintSet
    {
        public List<hclVolumeConstraintMxApplyBatchData> m_applyBatchDatas;
        public List<hclVolumeConstraintMxApplySingleData> m_applySingleDatas;

        public List<hclVolumeConstraintMxFrameBatchData> m_frameBatchDatas;
        public List<hclVolumeConstraintMxFrameSingleData> m_frameSingleDatas;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_frameBatchDatas = des.ReadClassArray<hclVolumeConstraintMxFrameBatchData>(br);
            m_frameSingleDatas = des.ReadClassArray<hclVolumeConstraintMxFrameSingleData>(br);
            m_applyBatchDatas = des.ReadClassArray<hclVolumeConstraintMxApplyBatchData>(br);
            m_applySingleDatas = des.ReadClassArray<hclVolumeConstraintMxApplySingleData>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_frameBatchDatas);
            s.WriteClassArray(bw, m_frameSingleDatas);
            s.WriteClassArray(bw, m_applyBatchDatas);
            s.WriteClassArray(bw, m_applySingleDatas);
        }
    }
}