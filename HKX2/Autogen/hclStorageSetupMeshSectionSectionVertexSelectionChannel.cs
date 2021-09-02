using System.Collections.Generic;

namespace HKX2
{
    public class
        hclStorageSetupMeshSectionSectionVertexSelectionChannel : hclStorageSetupMeshSectionSectionVertexChannel
    {
        public List<uint> m_vertexIndices;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_vertexIndices = des.ReadUInt32Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteUInt32Array(bw, m_vertexIndices);
        }
    }
}