namespace HKX2
{
    public class hkpPairCollisionFilterMapPairFilterKeyOverrideType : IHavokObject
    {
        public int m_hashMod;

        public int m_numElems;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            br.ReadUInt64();
            m_numElems = br.ReadInt32();
            m_hashMod = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt64(0);
            bw.WriteInt32(m_numElems);
            bw.WriteInt32(m_hashMod);
        }
    }
}