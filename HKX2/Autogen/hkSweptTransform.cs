using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkSweptTransform Signatire: 0xb4e5770 size: 80 flags: FLAGS_NONE

    // m_centerOfMass0 m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_centerOfMass1 m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_rotation0 m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_rotation1 m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_centerOfMassLocal m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    
    public class hkSweptTransform : IHavokObject
    {

        public Vector4 m_centerOfMass0;
        public Vector4 m_centerOfMass1;
        public Quaternion m_rotation0;
        public Quaternion m_rotation1;
        public Vector4 m_centerOfMassLocal;

        public uint Signature => 0xb4e5770;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_centerOfMass0 = br.ReadVector4();
            m_centerOfMass1 = br.ReadVector4();
            m_rotation0 = des.ReadQuaternion(br);
            m_rotation1 = des.ReadQuaternion(br);
            m_centerOfMassLocal = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteVector4(m_centerOfMass0);
            bw.WriteVector4(m_centerOfMass1);
            s.WriteQuaternion(bw, m_rotation0);
            s.WriteQuaternion(bw, m_rotation1);
            bw.WriteVector4(m_centerOfMassLocal);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

