using System.Collections.Generic;

namespace HKX2
{
    public class hkMeshBoneIndexMapping : IHavokObject
    {
        public List<short> m_mapping;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_mapping = des.ReadInt16Array(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteInt16Array(bw, m_mapping);
        }
    }
}