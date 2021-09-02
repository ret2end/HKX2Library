namespace HKX2
{
    public class hclCopyVerticesOperator : hclOperator
    {
        public bool m_copyNormals;

        public uint m_inputBufferIdx;
        public uint m_numberOfVertices;
        public uint m_outputBufferIdx;
        public uint m_startVertexIn;
        public uint m_startVertexOut;
        public override uint Signature => 0xE6DB074C;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);

            if (des._header.PointerSize == 8) br.Position -= 4;

            m_inputBufferIdx = br.ReadUInt32();
            m_outputBufferIdx = br.ReadUInt32();
            m_numberOfVertices = br.ReadUInt32();
            m_startVertexIn = br.ReadUInt32();
            m_startVertexOut = br.ReadUInt32();
            m_copyNormals = br.ReadBoolean();
            br.ReadByte();
            br.ReadUInt16();

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);

            if (s._header.PointerSize == 8) bw.Position -= 4;

            bw.WriteUInt32(m_inputBufferIdx);
            bw.WriteUInt32(m_outputBufferIdx);
            bw.WriteUInt32(m_numberOfVertices);
            bw.WriteUInt32(m_startVertexIn);
            bw.WriteUInt32(m_startVertexOut);
            bw.WriteBoolean(m_copyNormals);
            bw.WriteByte(0);
            bw.WriteUInt16(0);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}