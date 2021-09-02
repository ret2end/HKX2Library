namespace HKX2
{
    public class hkpNamedMeshMaterial : hkpMeshMaterial
    {
        public string m_name;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt32();
            m_name = des.ReadStringPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt32(0);
            s.WriteStringPointer(bw, m_name);
        }
    }
}