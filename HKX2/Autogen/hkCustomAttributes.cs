using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkCustomAttributes Signatire: 0xbff19005 size: 16 flags: FLAGS_NONE

    // m_attributes m_class: hkCustomAttributesAttribute Type.TYPE_SIMPLEARRAY Type.TYPE_STRUCT arrSize: 0 offset: 0 flags:  enum: 
    
    public class hkCustomAttributes : IHavokObject
    {

        public dynamic /*simpleArray struct*/ m_attributes;

        public uint Signature => 0xbff19005;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            throw new NotImplementedException("TPYE_SIMPLEARRAY");/*simple array*/

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            throw new NotImplementedException("TPYE_SIMPLEARRAY");/*simple array*/

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

