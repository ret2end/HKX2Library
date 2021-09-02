using System.Collections.Generic;

namespace HKX2
{
    public class hclTransitionConstraintSet : hclConstraintSet
    {
        public List<hclTransitionConstraintSetPerParticle> m_perParticleData;
        public uint m_referenceMeshBufferIdx;
        public float m_toAnimPeriod;
        public float m_toAnimPlusDelayPeriod;
        public float m_toSimPeriod;
        public float m_toSimPlusDelayPeriod;
        public override uint Signature => 0x9CFE2C7D;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_perParticleData = des.ReadClassArray<hclTransitionConstraintSetPerParticle>(br);
            m_toAnimPeriod = br.ReadSingle();
            m_toAnimPlusDelayPeriod = br.ReadSingle();
            m_toSimPeriod = br.ReadSingle();
            m_toSimPlusDelayPeriod = br.ReadSingle();
            m_referenceMeshBufferIdx = br.ReadUInt32();

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_perParticleData);
            bw.WriteSingle(m_toAnimPeriod);
            bw.WriteSingle(m_toAnimPlusDelayPeriod);
            bw.WriteSingle(m_toSimPeriod);
            bw.WriteSingle(m_toSimPlusDelayPeriod);
            bw.WriteUInt32(m_referenceMeshBufferIdx);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}