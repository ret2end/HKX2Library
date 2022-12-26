using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbComputeRotationToTargetModifier Signatire: 0x47665f1c size: 192 flags: FLAGS_NONE

    // m_rotationOut m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_targetPosition m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_currentPosition m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_currentRotation m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 128 flags:  enum: 
    // m_localAxisOfRotation m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 144 flags:  enum: 
    // m_localFacingDirection m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 160 flags:  enum: 
    // m_resultIsDelta m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 176 flags:  enum: 
    
    public class hkbComputeRotationToTargetModifier : hkbModifier
    {

        public Quaternion m_rotationOut;
        public Vector4 m_targetPosition;
        public Vector4 m_currentPosition;
        public Quaternion m_currentRotation;
        public Vector4 m_localAxisOfRotation;
        public Vector4 m_localFacingDirection;
        public bool m_resultIsDelta;

        public override uint Signature => 0x47665f1c;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_rotationOut = des.ReadQuaternion(br);
            m_targetPosition = br.ReadVector4();
            m_currentPosition = br.ReadVector4();
            m_currentRotation = des.ReadQuaternion(br);
            m_localAxisOfRotation = br.ReadVector4();
            m_localFacingDirection = br.ReadVector4();
            m_resultIsDelta = br.ReadBoolean();
            br.Position += 15;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteQuaternion(bw, m_rotationOut);
            bw.WriteVector4(m_targetPosition);
            bw.WriteVector4(m_currentPosition);
            s.WriteQuaternion(bw, m_currentRotation);
            bw.WriteVector4(m_localAxisOfRotation);
            bw.WriteVector4(m_localFacingDirection);
            bw.WriteBoolean(m_resultIsDelta);
            bw.Position += 15;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

