namespace HKX2
{
    public class hkpAction : hkReferencedObject
    {
        public string m_name;

        public ulong m_userData;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            br.ReadUInt64();
            m_userData = br.ReadUInt64();
            m_name = des.ReadStringPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(m_userData);
            s.WriteStringPointer(bw, m_name);
        }
    }
}