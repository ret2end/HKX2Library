using System.Collections.Generic;

namespace HKX2
{
    public enum VectorContext
    {
        VEC_POSITION = 0,
        VEC_DIRECTION = 1
    }

    public class hclBlendSomeVerticesOperator : hclOperator
    {
        public bool m_blendBitangents;

        public List<hclBlendSomeVerticesOperatorBlendEntry> m_blendEntries;
        public bool m_blendNormals;
        public bool m_blendTangents;
        public uint m_bufferIdx_A;
        public uint m_bufferIdx_B;
        public uint m_bufferIdx_C;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_blendEntries = des.ReadClassArray<hclBlendSomeVerticesOperatorBlendEntry>(br);
            m_bufferIdx_A = br.ReadUInt32();
            m_bufferIdx_B = br.ReadUInt32();
            m_bufferIdx_C = br.ReadUInt32();
            m_blendNormals = br.ReadBoolean();
            m_blendTangents = br.ReadBoolean();
            m_blendBitangents = br.ReadBoolean();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_blendEntries);
            bw.WriteUInt32(m_bufferIdx_A);
            bw.WriteUInt32(m_bufferIdx_B);
            bw.WriteUInt32(m_bufferIdx_C);
            bw.WriteBoolean(m_blendNormals);
            bw.WriteBoolean(m_blendTangents);
            bw.WriteBoolean(m_blendBitangents);
            bw.WriteByte(0);
        }
    }
}