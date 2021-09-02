using System.Collections.Generic;

namespace HKX2
{
    public class hkcdSimdTree : hkBaseObject
    {
        public List<hkcdSimdTreeNode> m_nodes;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_nodes = des.ReadClassArray<hkcdSimdTreeNode>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_nodes);
        }
    }
}