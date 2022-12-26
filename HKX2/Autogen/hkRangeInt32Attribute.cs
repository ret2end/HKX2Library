using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkRangeInt32Attribute Signatire: 0x4846be29 size: 16 flags: FLAGS_NONE

    // m_absmin m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_absmax m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_softmin m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_softmax m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    
    public class hkRangeInt32Attribute : IHavokObject
    {

        public int m_absmin;
        public int m_absmax;
        public int m_softmin;
        public int m_softmax;

        public uint Signature => 0x4846be29;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_absmin = br.ReadInt32();
            m_absmax = br.ReadInt32();
            m_softmin = br.ReadInt32();
            m_softmax = br.ReadInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteInt32(m_absmin);
            bw.WriteInt32(m_absmax);
            bw.WriteInt32(m_softmin);
            bw.WriteInt32(m_softmax);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

