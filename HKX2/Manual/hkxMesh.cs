using System.Collections.Generic;

namespace HKX2
{
    public class hkxMesh : hkReferencedObject
    {
        public List<hkxMeshSection> m_sections;
        public List<hkxMeshUserChannelInfo> m_userChannelInfos;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_sections = des.ReadClassPointerArray<hkxMeshSection>(br);
            m_userChannelInfos = des.ReadClassPointerArray<hkxMeshUserChannelInfo>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_sections);
            s.WriteClassPointerArray(bw, m_userChannelInfos);
        }
    }
}