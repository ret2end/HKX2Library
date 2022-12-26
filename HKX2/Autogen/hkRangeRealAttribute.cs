using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkRangeRealAttribute Signatire: 0x949db24f size: 16 flags: FLAGS_NONE

    // m_absmin m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_absmax m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_softmin m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_softmax m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    
    public class hkRangeRealAttribute : IHavokObject
    {

        public float m_absmin;
        public float m_absmax;
        public float m_softmin;
        public float m_softmax;

        public uint Signature => 0x949db24f;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_absmin = br.ReadSingle();
            m_absmax = br.ReadSingle();
            m_softmin = br.ReadSingle();
            m_softmax = br.ReadSingle();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteSingle(m_absmin);
            bw.WriteSingle(m_absmax);
            bw.WriteSingle(m_softmin);
            bw.WriteSingle(m_softmax);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

