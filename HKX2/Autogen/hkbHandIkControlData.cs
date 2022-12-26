using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbHandIkControlData Signatire: 0xd72b8d17 size: 96 flags: FLAGS_NONE

    // m_targetPosition m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_targetRotation m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_targetNormal m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_targetHandle m_class: hkbHandle Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags:  enum: 
    // m_transformOnFraction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 56 flags:  enum: 
    // m_normalOnFraction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 60 flags:  enum: 
    // m_fadeInDuration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_fadeOutDuration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 68 flags:  enum: 
    // m_extrapolationTimeStep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 72 flags:  enum: 
    // m_handleChangeSpeed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 76 flags:  enum: 
    // m_handleChangeMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 80 flags:  enum: HandleChangeMode
    // m_fixUp m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 81 flags:  enum: 
    
    public class hkbHandIkControlData : IHavokObject
    {

        public Vector4 m_targetPosition;
        public Quaternion m_targetRotation;
        public Vector4 m_targetNormal;
        public hkbHandle /*pointer struct*/ m_targetHandle;
        public float m_transformOnFraction;
        public float m_normalOnFraction;
        public float m_fadeInDuration;
        public float m_fadeOutDuration;
        public float m_extrapolationTimeStep;
        public float m_handleChangeSpeed;
        public sbyte m_handleChangeMode;
        public bool m_fixUp;

        public uint Signature => 0xd72b8d17;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_targetPosition = br.ReadVector4();
            m_targetRotation = des.ReadQuaternion(br);
            m_targetNormal = br.ReadVector4();
            m_targetHandle = des.ReadClassPointer<hkbHandle>(br);
            m_transformOnFraction = br.ReadSingle();
            m_normalOnFraction = br.ReadSingle();
            m_fadeInDuration = br.ReadSingle();
            m_fadeOutDuration = br.ReadSingle();
            m_extrapolationTimeStep = br.ReadSingle();
            m_handleChangeSpeed = br.ReadSingle();
            m_handleChangeMode = br.ReadSByte();
            m_fixUp = br.ReadBoolean();
            br.Position += 14;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteVector4(m_targetPosition);
            s.WriteQuaternion(bw, m_targetRotation);
            bw.WriteVector4(m_targetNormal);
            s.WriteClassPointer(bw, m_targetHandle);
            bw.WriteSingle(m_transformOnFraction);
            bw.WriteSingle(m_normalOnFraction);
            bw.WriteSingle(m_fadeInDuration);
            bw.WriteSingle(m_fadeOutDuration);
            bw.WriteSingle(m_extrapolationTimeStep);
            bw.WriteSingle(m_handleChangeSpeed);
            s.WriteSByte(bw, m_handleChangeMode);
            bw.WriteBoolean(m_fixUp);
            bw.Position += 14;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

