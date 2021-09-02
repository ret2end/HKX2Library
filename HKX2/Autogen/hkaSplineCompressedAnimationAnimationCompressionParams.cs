namespace HKX2
{
    public class hkaSplineCompressedAnimationAnimationCompressionParams : IHavokObject
    {
        public bool m_enableSampleSingleTracks;

        public ushort m_maxFramesPerBlock;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_maxFramesPerBlock = br.ReadUInt16();
            m_enableSampleSingleTracks = br.ReadBoolean();
            br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt16(m_maxFramesPerBlock);
            bw.WriteBoolean(m_enableSampleSingleTracks);
            bw.WriteByte(0);
        }
    }
}