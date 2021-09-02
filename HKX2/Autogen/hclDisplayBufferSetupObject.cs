namespace HKX2
{
    public class hclDisplayBufferSetupObject : hclBufferSetupObject
    {
        public string m_name;

        public hclSetupMesh m_setupMesh;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_setupMesh = des.ReadClassPointer<hclSetupMesh>(br);
            m_name = des.ReadStringPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_setupMesh);
            s.WriteStringPointer(bw, m_name);
        }
    }
}