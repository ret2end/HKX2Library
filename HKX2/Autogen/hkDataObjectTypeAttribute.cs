using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkDataObjectTypeAttribute Signatire: 0x1e3857bb size: 8 flags: FLAGS_NONE

    // m_typeName m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    
    public class hkDataObjectTypeAttribute : IHavokObject
    {

        public string m_typeName;

        public uint Signature => 0x1e3857bb;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_typeName = des.ReadStringPointer(br);//m_typeName = br.ReadASCII();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_typeName);//bw.WriteASCII(m_typeName, true);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

