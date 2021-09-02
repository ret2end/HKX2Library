namespace HKX2
{
    public enum MergeType
    {
        UNUSED_MERGING_SIMPLE = 0,
        UNUSED_MERGING_CONVEX_HULL = 1
    }

    public class hkaiSilhouetteMerger : hkReferencedObject
    {
        public hkaiSilhouetteGenerationParameters m_mergeParams;

        public MergeType m_mergeType;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_mergeType = (MergeType) br.ReadByte();
            br.ReadUInt16();
            br.ReadByte();
            m_mergeParams = new hkaiSilhouetteGenerationParameters();
            m_mergeParams.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteByte((byte) m_mergeType);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            m_mergeParams.Write(s, bw);
        }
    }
}