using System.Collections.Generic;

namespace HKX2
{
    public class hkMemoryResourceContainer : hkResourceContainer
    {
        public List<hkMemoryResourceContainer> m_children;

        public string m_name;
        public List<hkMemoryResourceHandle> m_resourceHandles;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            br.ReadUInt64();
            m_resourceHandles = des.ReadClassPointerArray<hkMemoryResourceHandle>(br);
            m_children = des.ReadClassPointerArray<hkMemoryResourceContainer>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            bw.WriteUInt64(0);
            s.WriteClassPointerArray(bw, m_resourceHandles);
            s.WriteClassPointerArray(bw, m_children);
        }
    }
}