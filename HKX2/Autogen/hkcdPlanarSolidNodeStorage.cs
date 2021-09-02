using System.Collections.Generic;

namespace HKX2
{
    public class hkcdPlanarSolidNodeStorage : hkReferencedObject
    {
        public List<hkAabb> m_aabbs;
        public uint m_firstFreeNodeId;

        public List<hkcdPlanarSolidNode> m_storage;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_storage = des.ReadClassArray<hkcdPlanarSolidNode>(br);
            m_aabbs = des.ReadClassArray<hkAabb>(br);
            m_firstFreeNodeId = br.ReadUInt32();
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_storage);
            s.WriteClassArray(bw, m_aabbs);
            bw.WriteUInt32(m_firstFreeNodeId);
            bw.WriteUInt32(0);
        }
    }
}