namespace HKX2
{
    public class hkaiNavMeshClearanceCacheMcpDataInteger : IHavokObject
    {
        public byte m_clearance;

        public byte m_interpolant;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_interpolant = br.ReadByte();
            m_clearance = br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteByte(m_interpolant);
            bw.WriteByte(m_clearance);
        }
    }
}