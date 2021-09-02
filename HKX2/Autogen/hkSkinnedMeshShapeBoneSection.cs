namespace HKX2
{
    public class hkSkinnedMeshShapeBoneSection : IHavokObject
    {
        public hkMeshShape m_meshBuffer;
        public short m_numBoneSets;
        public ushort m_startBoneSetId;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_meshBuffer = des.ReadClassPointer<hkMeshShape>(br);
            m_startBoneSetId = br.ReadUInt16();
            m_numBoneSets = br.ReadInt16();
            br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_meshBuffer);
            bw.WriteUInt16(m_startBoneSetId);
            bw.WriteInt16(m_numBoneSets);
            bw.WriteUInt32(0);
        }
    }
}