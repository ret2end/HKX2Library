using System.Collections.Generic;

namespace HKX2
{
    public enum ForceUpgrade610
    {
        HCL_FORCE_UPGRADE610 = 0
    }

    public class hclMoveParticlesOperator : hclOperator
    {
        public uint m_refBufferIdx;
        public uint m_simClothIndex;

        public List<hclMoveParticlesOperatorVertexParticlePair> m_vertexParticlePairs;
        public override uint Signature => 0xE65A701C;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_vertexParticlePairs = des.ReadClassArray<hclMoveParticlesOperatorVertexParticlePair>(br);
            m_simClothIndex = br.ReadUInt32();
            m_refBufferIdx = br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_vertexParticlePairs);
            bw.WriteUInt32(m_simClothIndex);
            bw.WriteUInt32(m_refBufferIdx);
        }
    }
}