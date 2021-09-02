using System.Collections.Generic;

namespace HKX2
{
    public class hclBoneSpaceSkinOperator : hclOperator
    {
        public hclBoneSpaceDeformer m_boneSpaceDeformer;
        public uint m_outputBufferIndex;
        public uint m_transformSetIndex;

        public List<ushort> m_transformSubset;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_transformSubset = des.ReadUInt16Array(br);
            m_outputBufferIndex = br.ReadUInt32();
            m_transformSetIndex = br.ReadUInt32();
            m_boneSpaceDeformer = new hclBoneSpaceDeformer();
            m_boneSpaceDeformer.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteUInt16Array(bw, m_transformSubset);
            bw.WriteUInt32(m_outputBufferIndex);
            bw.WriteUInt32(m_transformSetIndex);
            m_boneSpaceDeformer.Write(s, bw);
        }
    }
}