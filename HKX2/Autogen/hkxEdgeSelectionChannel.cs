using System.Collections.Generic;

namespace HKX2
{
    public class hkxEdgeSelectionChannel : hkReferencedObject
    {
        public List<int> m_selectedEdges;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_selectedEdges = des.ReadInt32Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteInt32Array(bw, m_selectedEdges);
        }
    }
}