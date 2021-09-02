using System.Collections.Generic;

namespace HKX2
{
    public class hclStorageSetupMeshSectionSectionEdgeSelectionChannel : hkReferencedObject
    {
        public List<uint> m_edgeIndices;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_edgeIndices = des.ReadUInt32Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteUInt32Array(bw, m_edgeIndices);
        }
    }
}