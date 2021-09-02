namespace HKX2
{
    public class hclClothStateTransformSetAccess : IHavokObject
    {
        public uint m_transformSetIndex;
        public hclTransformSetUsage m_transformSetUsage;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_transformSetIndex = br.ReadUInt32();

            if (des._header.PointerSize == 8) br.ReadUInt32();

            m_transformSetUsage = new hclTransformSetUsage();
            m_transformSetUsage.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_transformSetIndex);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);

            m_transformSetUsage.Write(s, bw);
        }
    }
}