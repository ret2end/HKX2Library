namespace HKX2
{
    public class hkpPoweredChainMapperTarget : IHavokObject
    {
        public hkpPoweredChainData m_chain;
        public int m_infoIndex;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_chain = des.ReadClassPointer<hkpPoweredChainData>(br);
            m_infoIndex = br.ReadInt32();
            br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_chain);
            bw.WriteInt32(m_infoIndex);
            bw.WriteUInt32(0);
        }
    }
}