namespace HKX2
{
    public class hclNamedTransformSetSetupObject : hclTransformSetSetupObject
    {
        public string m_name;
        public string m_skelName;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_skelName = des.ReadStringPointer(br);
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteStringPointer(bw, m_skelName);
            bw.WriteUInt64(0);
        }
    }
}