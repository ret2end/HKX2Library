using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkCustomAttributesAttribute Signatire: 0x1388d601 size: 24 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_value m_class:  Type.TYPE_VARIANT Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkCustomAttributesAttribute : IHavokObject
    {

        public string m_name;
        public dynamic /*variant void*/ m_value;

        public uint Signature => 0x1388d601;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_name = des.ReadStringPointer(br);//m_name = br.ReadASCII();
            throw new NotImplementedException("TPYE_VARIANT");/*variant*/

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_name);//bw.WriteASCII(m_name, true);
            throw new NotImplementedException("TPYE_VARIANT");/*variant*/

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

