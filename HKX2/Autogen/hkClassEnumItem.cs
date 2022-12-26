using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkClassEnumItem Signatire: 0xce6f8a6c size: 16 flags: FLAGS_NONE

    // m_value m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_name m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 

    public class hkClassEnumItem : IHavokObject
    {

        public int m_value;
        public string m_name;

        public uint Signature => 0xce6f8a6c;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_value = br.ReadInt32();
            br.Position += 4;
            m_name = des.ReadStringPointer(br);//m_name = br.ReadASCII();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteInt32(m_value);
            bw.Position += 4;
            s.WriteStringPointer(bw, m_name);//bw.WriteASCII(m_name, true);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

