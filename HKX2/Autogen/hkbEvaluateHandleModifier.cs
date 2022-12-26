using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbEvaluateHandleModifier Signatire: 0x79757102 size: 240 flags: FLAGS_NONE

    // m_handle m_class: hkbHandle Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags:  enum: 
    // m_handlePositionOut m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_handleRotationOut m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_isValidOut m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 128 flags:  enum: 
    // m_extrapolationTimeStep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 132 flags:  enum: 
    // m_handleChangeSpeed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 136 flags:  enum: 
    // m_handleChangeMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 140 flags:  enum: HandleChangeMode
    // m_oldHandle m_class: hkbHandle Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 144 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_oldHandlePosition m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 192 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_oldHandleRotation m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 208 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_timeSinceLastModify m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 224 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_smoothlyChangingHandles m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 228 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbEvaluateHandleModifier : hkbModifier
    {

        public hkbHandle /*pointer struct*/ m_handle;
        public Vector4 m_handlePositionOut;
        public Quaternion m_handleRotationOut;
        public bool m_isValidOut;
        public float m_extrapolationTimeStep;
        public float m_handleChangeSpeed;
        public sbyte m_handleChangeMode;
        public hkbHandle/*struct void*/ m_oldHandle;
        public Vector4 m_oldHandlePosition;
        public Quaternion m_oldHandleRotation;
        public float m_timeSinceLastModify;
        public bool m_smoothlyChangingHandles;

        public override uint Signature => 0x79757102;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_handle = des.ReadClassPointer<hkbHandle>(br);
            br.Position += 8;
            m_handlePositionOut = br.ReadVector4();
            m_handleRotationOut = des.ReadQuaternion(br);
            m_isValidOut = br.ReadBoolean();
            br.Position += 3;
            m_extrapolationTimeStep = br.ReadSingle();
            m_handleChangeSpeed = br.ReadSingle();
            m_handleChangeMode = br.ReadSByte();
            br.Position += 3;
            m_oldHandle = new hkbHandle();
            m_oldHandle.Read(des,br);
            m_oldHandlePosition = br.ReadVector4();
            m_oldHandleRotation = des.ReadQuaternion(br);
            m_timeSinceLastModify = br.ReadSingle();
            m_smoothlyChangingHandles = br.ReadBoolean();
            br.Position += 11;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_handle);
            bw.Position += 8;
            bw.WriteVector4(m_handlePositionOut);
            s.WriteQuaternion(bw, m_handleRotationOut);
            bw.WriteBoolean(m_isValidOut);
            bw.Position += 3;
            bw.WriteSingle(m_extrapolationTimeStep);
            bw.WriteSingle(m_handleChangeSpeed);
            s.WriteSByte(bw, m_handleChangeMode);
            bw.Position += 3;
            m_oldHandle.Write(s, bw);
            bw.WriteVector4(m_oldHandlePosition);
            s.WriteQuaternion(bw, m_oldHandleRotation);
            bw.WriteSingle(m_timeSinceLastModify);
            bw.WriteBoolean(m_smoothlyChangingHandles);
            bw.Position += 11;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

