using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkContactPoint Signatire: 0x91d7dd8e size: 32 flags: FLAGS_NONE

    // m_position m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_separatingNormal m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkContactPoint : IHavokObject
    {

        public Vector4 m_position;
        public Vector4 m_separatingNormal;

        public uint Signature => 0x91d7dd8e;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_position = br.ReadVector4();
            m_separatingNormal = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteVector4(m_position);
            bw.WriteVector4(m_separatingNormal);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

