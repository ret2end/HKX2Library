using System.Collections.Generic;

namespace HKX2
{
    public class hclScratchBufferDefinition : hclBufferDefinition
    {
        public bool m_storeNormals;
        public bool m_storeTangentsAndBiTangents;

        public List<ushort> m_triangleIndices;
        public override uint Signature => 0xA0130A2C;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_triangleIndices = des.ReadUInt16Array(br);
            m_storeNormals = br.ReadBoolean();
            m_storeTangentsAndBiTangents = br.ReadBoolean();
            br.ReadUInt16();

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteUInt16Array(bw, m_triangleIndices);
            bw.WriteBoolean(m_storeNormals);
            bw.WriteBoolean(m_storeTangentsAndBiTangents);
            bw.WriteUInt16(0);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}