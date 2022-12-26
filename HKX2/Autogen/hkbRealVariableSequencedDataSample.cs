using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbRealVariableSequencedDataSample Signatire: 0xbb708bbd size: 8 flags: FLAGS_NONE

    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_value m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    
    public class hkbRealVariableSequencedDataSample : IHavokObject
    {

        public float m_time;
        public float m_value;

        public uint Signature => 0xbb708bbd;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_time = br.ReadSingle();
            m_value = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteSingle(m_time);
            bw.WriteSingle(m_value);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

