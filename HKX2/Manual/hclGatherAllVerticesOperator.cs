using System.Collections.Generic;

namespace HKX2
{
    public class hclGatherAllVerticesOperator : hclOperator
    {
        public bool m_gatherNormals;
        public uint m_inputBufferIdx;
        public uint m_outputBufferIdx;
        public bool m_partialGather;

        public List<short> m_vertexInputFromVertexOutput;
        public override uint Signature => 0xDA737296;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_vertexInputFromVertexOutput = des.ReadInt16Array(br);
            m_inputBufferIdx = br.ReadUInt32();
            m_outputBufferIdx = br.ReadUInt32();
            m_gatherNormals = br.ReadBoolean();
            m_partialGather = br.ReadBoolean();
            br.ReadUInt16();

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteInt16Array(bw, m_vertexInputFromVertexOutput);
            bw.WriteUInt32(m_inputBufferIdx);
            bw.WriteUInt32(m_outputBufferIdx);
            bw.WriteBoolean(m_gatherNormals);
            bw.WriteBoolean(m_partialGather);
            bw.WriteUInt16(0);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}