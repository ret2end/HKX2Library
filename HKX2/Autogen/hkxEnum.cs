using System.Collections.Generic;

namespace HKX2
{
    public class hkxEnum : hkReferencedObject
    {
        public List<hkxEnumItem> m_items;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_items = des.ReadClassArray<hkxEnumItem>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_items);
        }
    }
}