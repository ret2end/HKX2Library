namespace HKX2
{
    public class hkUuidObject : hkReferencedObject
    {
        public hkUuid m_uuid;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_uuid = new hkUuid();
            m_uuid.Read(des, br);
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_uuid.Write(s, bw);
            bw.WriteUInt32(0);
        }
    }
}