using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkQTransform Signatire: 0x471a21ee size: 32 flags: FLAGS_NONE

    // m_rotation m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_translation m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkQTransform : IHavokObject
    {

        public Quaternion m_rotation;
        public Vector4 m_translation;

        public uint Signature => 0x471a21ee;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_rotation = des.ReadQuaternion(br);
            m_translation = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteQuaternion(bw, m_rotation);
            bw.WriteVector4(m_translation);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

