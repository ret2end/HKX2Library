namespace HKX2
{
    public class hkaiPersistentEdgeKey : IHavokObject
    {
        public short m_edgeOffset;

        public hkaiPersistentFaceKey m_faceKey;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_faceKey = new hkaiPersistentFaceKey();
            m_faceKey.Read(des, br);
            m_edgeOffset = br.ReadInt16();
            br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_faceKey.Write(s, bw);
            bw.WriteInt16(m_edgeOffset);
            bw.WriteUInt16(0);
        }
    }
}