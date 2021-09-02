namespace HKX2
{
    public class hclNamedSetupMesh : hclSetupMesh
    {
        public string m_meshName;

        public string m_name;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_meshName = des.ReadStringPointer(br);
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteStringPointer(bw, m_meshName);
            bw.WriteUInt64(0);
        }
    }
}