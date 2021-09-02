namespace HKX2
{
    public class hkaiNavVolumeGenerationSettingsMaterialConstructionInfo : IHavokObject
    {
        public uint m_flags;

        public int m_materialIndex;
        public int m_resolution;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_materialIndex = br.ReadInt32();
            m_flags = br.ReadUInt32();
            m_resolution = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_materialIndex);
            bw.WriteUInt32(m_flags);
            bw.WriteInt32(m_resolution);
        }
    }
}