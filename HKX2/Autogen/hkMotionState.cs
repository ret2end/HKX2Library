using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkMotionState Signatire: 0x5797386e size: 176 flags: FLAGS_NONE

    // m_transform m_class:  Type.TYPE_TRANSFORM Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_sweptTransform m_class: hkSweptTransform Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_deltaAngle m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 144 flags:  enum: 
    // m_objectRadius m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 160 flags:  enum: 
    // m_linearDamping m_class:  Type.TYPE_HALF Type.TYPE_VOID arrSize: 0 offset: 164 flags:  enum: 
    // m_angularDamping m_class:  Type.TYPE_HALF Type.TYPE_VOID arrSize: 0 offset: 166 flags:  enum: 
    // m_timeFactor m_class:  Type.TYPE_HALF Type.TYPE_VOID arrSize: 0 offset: 168 flags:  enum: 
    // m_maxLinearVelocity m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 170 flags:  enum: 
    // m_maxAngularVelocity m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 171 flags:  enum: 
    // m_deactivationClass m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 172 flags:  enum: 
    
    public class hkMotionState : IHavokObject
    {

        public Matrix4x4 m_transform;
        public hkSweptTransform/*struct void*/ m_sweptTransform;
        public Vector4 m_deltaAngle;
        public float m_objectRadius;
        public Half m_linearDamping;
        public Half m_angularDamping;
        public Half m_timeFactor;
        public byte m_maxLinearVelocity;
        public byte m_maxAngularVelocity;
        public byte m_deactivationClass;

        public uint Signature => 0x5797386e;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_transform = des.ReadTransform(br);
            m_sweptTransform = new hkSweptTransform();
            m_sweptTransform.Read(des,br);
            m_deltaAngle = br.ReadVector4();
            m_objectRadius = br.ReadSingle();
            m_linearDamping = br.ReadHalf();
            m_angularDamping = br.ReadHalf();
            m_timeFactor = br.ReadHalf();
            m_maxLinearVelocity = br.ReadByte();
            m_maxAngularVelocity = br.ReadByte();
            m_deactivationClass = br.ReadByte();
            br.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteTransform(bw, m_transform);
            m_sweptTransform.Write(s, bw);
            bw.WriteVector4(m_deltaAngle);
            bw.WriteSingle(m_objectRadius);
            bw.WriteHalf(m_linearDamping);
            bw.WriteHalf(m_angularDamping); 
            bw.WriteHalf(m_timeFactor);
            bw.WriteByte(m_maxLinearVelocity);
            bw.WriteByte(m_maxAngularVelocity);
            bw.WriteByte(m_deactivationClass);
            bw.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

