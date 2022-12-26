using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbVariableInfo Signatire: 0x9e746ba2 size: 6 flags: FLAGS_NONE

    // m_role m_class: hkbRoleAttribute Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 4 flags:  enum: VariableType
    
    public class hkbVariableInfo : IHavokObject
    {

        public hkbRoleAttribute/*struct void*/ m_role;
        public sbyte m_type;

        public uint Signature => 0x9e746ba2;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_role = new hkbRoleAttribute();
            m_role.Read(des,br);
            m_type = br.ReadSByte();
            br.Position += 1;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_role.Write(s, bw);
            s.WriteSByte(bw, m_type);
            bw.Position += 1;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

