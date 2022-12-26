using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpMultiRayShapeRay Signatire: 0xffdc0b65 size: 32 flags: FLAGS_NONE

    // m_start m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_end m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkpMultiRayShapeRay : IHavokObject
    {

        public Vector4 m_start;
        public Vector4 m_end;

        public uint Signature => 0xffdc0b65;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_start = br.ReadVector4();
            m_end = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteVector4(m_start);
            bw.WriteVector4(m_end);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

