using System.Collections.Generic;

namespace HKX2
{
    public class hkxNodeSelectionSet : hkxAttributeHolder
    {
        public string m_name;

        public List<hkxNode> m_selectedNodes;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_selectedNodes = des.ReadClassPointerArray<hkxNode>(br);
            m_name = des.ReadStringPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_selectedNodes);
            s.WriteStringPointer(bw, m_name);
        }
    }
}