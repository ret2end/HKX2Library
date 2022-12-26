using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConvexVerticesShapeFourVectors Signatire: 0x3d80c5bf size: 48 flags: FLAGS_NONE

    // m_x m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_y m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_z m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkpConvexVerticesShapeFourVectors : IHavokObject
    {

        public Vector4 m_x;
        public Vector4 m_y;
        public Vector4 m_z;

        public uint Signature => 0x3d80c5bf;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_x = br.ReadVector4();
            m_y = br.ReadVector4();
            m_z = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteVector4(m_x);
            bw.WriteVector4(m_y);
            bw.WriteVector4(m_z);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

