using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbRoleAttribute Signatire: 0x3eb2e082 size: 4 flags: FLAGS_NONE

    // m_role m_class:  Type.TYPE_ENUM Type.TYPE_INT16 arrSize: 0 offset: 0 flags:  enum: Role
    // m_flags m_class:  Type.TYPE_FLAGS Type.TYPE_INT16 arrSize: 0 offset: 2 flags:  enum: RoleFlags
    
    public class hkbRoleAttribute : IHavokObject
    {

        public short m_role;
        public short m_flags;

        public uint Signature => 0x3eb2e082;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_role = br.ReadInt16();
            m_flags = br.ReadInt16();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteInt16(bw, m_role);
            bw.WriteInt16(m_flags);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

