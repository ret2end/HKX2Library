using System.Collections.Generic;

namespace HKX2
{
    public class hkMemoryResourceHandle : hkResourceHandle
    {
        public string m_name;
        public List<hkMemoryResourceHandleExternalLink> m_references;

        public hkReferencedObject m_variant;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_variant = des.ReadClassPointer<hkReferencedObject>(br);
            m_name = des.ReadStringPointer(br);
            m_references = des.ReadClassArray<hkMemoryResourceHandleExternalLink>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_variant);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassArray(bw, m_references);
        }
    }
}