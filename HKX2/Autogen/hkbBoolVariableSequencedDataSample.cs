using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbBoolVariableSequencedDataSample Signatire: 0x514763dc size: 8 flags: FLAGS_NONE

    // m_time m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_value m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    
    public class hkbBoolVariableSequencedDataSample : IHavokObject
    {

        public float m_time;
        public bool m_value;

        public uint Signature => 0x514763dc;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_time = br.ReadSingle();
            m_value = br.ReadBoolean();
            br.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteSingle(m_time);
            bw.WriteBoolean(m_value);
            bw.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

