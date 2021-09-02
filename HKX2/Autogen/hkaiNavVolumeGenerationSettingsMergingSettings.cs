namespace HKX2
{
    public class hkaiNavVolumeGenerationSettingsMergingSettings : IHavokObject
    {
        public float m_edgeWeight;
        public bool m_estimateNewEdges;
        public int m_iterationsStabilizationThreshold;
        public int m_maxMergingIterations;
        public float m_multiplier;

        public float m_nodeWeight;
        public int m_randomSeed;
        public float m_slopeThreshold;
        public bool m_useSimpleFirstMergePass;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_nodeWeight = br.ReadSingle();
            m_edgeWeight = br.ReadSingle();
            m_estimateNewEdges = br.ReadBoolean();
            br.ReadUInt16();
            br.ReadByte();
            m_iterationsStabilizationThreshold = br.ReadInt32();
            m_slopeThreshold = br.ReadSingle();
            m_maxMergingIterations = br.ReadInt32();
            m_randomSeed = br.ReadInt32();
            m_multiplier = br.ReadSingle();
            m_useSimpleFirstMergePass = br.ReadBoolean();
            br.ReadUInt16();
            br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_nodeWeight);
            bw.WriteSingle(m_edgeWeight);
            bw.WriteBoolean(m_estimateNewEdges);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            bw.WriteInt32(m_iterationsStabilizationThreshold);
            bw.WriteSingle(m_slopeThreshold);
            bw.WriteInt32(m_maxMergingIterations);
            bw.WriteInt32(m_randomSeed);
            bw.WriteSingle(m_multiplier);
            bw.WriteBoolean(m_useSimpleFirstMergePass);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}