namespace HKX2
{
    public class hclTransformSetDefinition : hkReferencedObject
    {
        public string m_name;
        public uint m_numTransforms;
        public int m_type;
        public override uint Signature => 0x18FD4565;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_type = br.ReadInt32();
            m_numTransforms = br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            bw.WriteInt32(m_type);
            bw.WriteUInt32(m_numTransforms);
        }
    }
}