namespace HKX2
{
    public class hkxTextureFile : hkReferencedObject
    {
        public string m_filename;
        public string m_name;
        public string m_originalFilename;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_filename = des.ReadStringPointer(br);
            m_name = des.ReadStringPointer(br);
            m_originalFilename = des.ReadStringPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_filename);
            s.WriteStringPointer(bw, m_name);
            s.WriteStringPointer(bw, m_originalFilename);
        }
    }
}