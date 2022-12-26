using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkPackedVector3 Signatire: 0x9c16df5b size: 8 flags: FLAGS_NONE

    // m_values m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 4 offset: 0 flags:  enum: 
    
    public class hkPackedVector3 : IHavokObject
    {

        public List<short> m_values;

        public uint Signature => 0x9c16df5b;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_values = des.ReadInt16CStyleArray(br, 4);//m_values = br.ReadInt16();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteInt16CStyleArray(bw, m_values);//bw.WriteInt16(m_values);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

