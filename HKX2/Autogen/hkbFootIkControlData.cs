using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbFootIkControlData Signatire: 0xa111b704 size: 48 flags: FLAGS_NONE

    // m_gains m_class: hkbFootIkGains Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbFootIkControlData : IHavokObject
    {

        public hkbFootIkGains/*struct void*/ m_gains;

        public uint Signature => 0xa111b704;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_gains = new hkbFootIkGains();
            m_gains.Read(des,br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_gains.Write(s, bw);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

