using System.Collections.Generic;

namespace HKX2
{
    public class hclStorageSetupMeshSectionSectionTriangleSelectionChannel : hkReferencedObject
    {
        public List<uint> m_triangleIndices;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_triangleIndices = des.ReadUInt32Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteUInt32Array(bw, m_triangleIndices);
        }
    }
}