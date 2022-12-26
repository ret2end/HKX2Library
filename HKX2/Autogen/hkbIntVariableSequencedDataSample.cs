using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbIntVariableSequencedDataSample Signatire: 0xbe7ac63c size: 8 flags: FLAGS_NONE

    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_value m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    
    public class hkbIntVariableSequencedDataSample : IHavokObject
    {

        public float m_time;
        public int m_value;

        public uint Signature => 0xbe7ac63c;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_time = br.ReadSingle();
            m_value = br.ReadInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteSingle(m_time);
            bw.WriteInt32(m_value);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

