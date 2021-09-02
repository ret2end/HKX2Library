namespace HKX2
{
    public class hclBufferDefinition : hkReferencedObject
    {
        public hclBufferLayout m_bufferLayout;

        public string m_name;
        public uint m_numTriangles;
        public uint m_numVertices;
        public int m_subType;
        public int m_type;
        public override uint Signature => 0x7F4A5BFC;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_type = br.ReadInt32();
            m_subType = br.ReadInt32();
            m_numVertices = br.ReadUInt32();
            m_numTriangles = br.ReadUInt32();
            m_bufferLayout = new hclBufferLayout();
            m_bufferLayout.Read(des, br);
            br.ReadUInt16();

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            bw.WriteInt32(m_type);
            bw.WriteInt32(m_subType);
            bw.WriteUInt32(m_numVertices);
            bw.WriteUInt32(m_numTriangles);
            m_bufferLayout.Write(s, bw);
            bw.WriteUInt16(0);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}