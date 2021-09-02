using System.Collections.Generic;

namespace HKX2
{
    public class hkClassEnum : IHavokObject
    {
        public enum FlagValues
        {
            FLAGS_NONE = 0
        }

        public uint m_flags;
        public List<hkClassEnumItem> m_items;

        public string m_name;
        public virtual uint Signature => 2318797263;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_name = des.ReadStringPointer(br);
            // Read TYPE_SIMPLEARRAY
            br.ReadUInt64();
            m_flags = br.ReadUInt32();
            br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_name);
            // Read TYPE_SIMPLEARRAY
            bw.WriteUInt64(0);
            bw.WriteUInt32(m_flags);
            bw.WriteUInt32(0);
        }
    }
}