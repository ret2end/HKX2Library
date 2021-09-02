namespace HKX2
{
    public class hkaiNavMeshGenerationSettingsOverrideSettings : IHavokObject
    {
        public CharacterWidthUsage m_characterWidthUsage;
        public hkaiNavMeshEdgeMatchingParameters m_edgeMatchingParams;
        public int m_material;
        public float m_maxWalkableSlope;
        public hkaiNavMeshSimplificationUtilsSettings m_simplificationSettings;

        public hkaiVolume m_volume;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_volume = des.ReadClassPointer<hkaiVolume>(br);
            m_material = br.ReadInt32();
            m_characterWidthUsage = (CharacterWidthUsage) br.ReadByte();
            br.ReadUInt16();
            br.ReadByte();
            m_maxWalkableSlope = br.ReadSingle();
            m_edgeMatchingParams = new hkaiNavMeshEdgeMatchingParameters();
            m_edgeMatchingParams.Read(des, br);
            br.ReadUInt32();
            m_simplificationSettings = new hkaiNavMeshSimplificationUtilsSettings();
            m_simplificationSettings.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_volume);
            bw.WriteInt32(m_material);
            bw.WriteByte((byte) m_characterWidthUsage);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            bw.WriteSingle(m_maxWalkableSlope);
            m_edgeMatchingParams.Write(s, bw);
            bw.WriteUInt32(0);
            m_simplificationSettings.Write(s, bw);
        }
    }
}