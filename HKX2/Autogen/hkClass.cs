using System.Collections.Generic;

namespace HKX2
{
    public enum SignatureFlags
    {
        SIGNATURE_LOCAL = 1
    }

    public class hkClass : IHavokObject
    {
        public enum FlagValues
        {
            FLAGS_NONE = 0,
            FLAGS_NOT_SERIALIZABLE = 1
        }

        public List<hkClassEnum> m_declaredEnums;
        public List<hkClassMember> m_declaredMembers;
        public int m_describedVersion;
        public uint m_flags;

        public string m_name;
        public int m_numImplementedInterfaces;
        public int m_objectSize;
        public hkClass m_parent;
        public virtual uint Signature => 869540739;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_name = des.ReadStringPointer(br);
            m_parent = des.ReadClassPointer<hkClass>(br);
            m_objectSize = br.ReadInt32();
            m_numImplementedInterfaces = br.ReadInt32();
            // Read TYPE_SIMPLEARRAY
            // Read TYPE_SIMPLEARRAY
            br.ReadUInt64();
            br.ReadUInt64();
            m_flags = br.ReadUInt32();
            m_describedVersion = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointer(bw, m_parent);
            bw.WriteInt32(m_objectSize);
            bw.WriteInt32(m_numImplementedInterfaces);
            // Read TYPE_SIMPLEARRAY
            // Read TYPE_SIMPLEARRAY
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt32(m_flags);
            bw.WriteInt32(m_describedVersion);
        }
    }
}