using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpCharacterRigidBodyCinfo Signatire: 0x892f441 size: 128 flags: FLAGS_NONE

    // m_collisionFilterInfo m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_shape m_class: hkpShape Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags:  enum: 
    // m_position m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_rotation m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_mass m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_friction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 68 flags:  enum: 
    // m_maxLinearVelocity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 72 flags:  enum: 
    // m_allowedPenetrationDepth m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 76 flags:  enum: 
    // m_up m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_maxSlope m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_maxForce m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags:  enum: 
    // m_unweldingHeightOffsetFactor m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 104 flags:  enum: 
    // m_maxSpeedForSimplexSolver m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 108 flags:  enum: 
    // m_supportDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_hardSupportDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 116 flags:  enum: 
    // m_vdbColor m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 120 flags:  enum: 
    
    public class hkpCharacterRigidBodyCinfo : hkpCharacterControllerCinfo
    {

        public uint m_collisionFilterInfo;
        public hkpShape /*pointer struct*/ m_shape;
        public Vector4 m_position;
        public Quaternion m_rotation;
        public float m_mass;
        public float m_friction;
        public float m_maxLinearVelocity;
        public float m_allowedPenetrationDepth;
        public Vector4 m_up;
        public float m_maxSlope;
        public float m_maxForce;
        public float m_unweldingHeightOffsetFactor;
        public float m_maxSpeedForSimplexSolver;
        public float m_supportDistance;
        public float m_hardSupportDistance;
        public int m_vdbColor;

        public override uint Signature => 0x892f441;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_collisionFilterInfo = br.ReadUInt32();
            br.Position += 4;
            m_shape = des.ReadClassPointer<hkpShape>(br);
            m_position = br.ReadVector4();
            m_rotation = des.ReadQuaternion(br);
            m_mass = br.ReadSingle();
            m_friction = br.ReadSingle();
            m_maxLinearVelocity = br.ReadSingle();
            m_allowedPenetrationDepth = br.ReadSingle();
            m_up = br.ReadVector4();
            m_maxSlope = br.ReadSingle();
            m_maxForce = br.ReadSingle();
            m_unweldingHeightOffsetFactor = br.ReadSingle();
            m_maxSpeedForSimplexSolver = br.ReadSingle();
            m_supportDistance = br.ReadSingle();
            m_hardSupportDistance = br.ReadSingle();
            m_vdbColor = br.ReadInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteUInt32(m_collisionFilterInfo);
            bw.Position += 4;
            s.WriteClassPointer(bw, m_shape);
            bw.WriteVector4(m_position);
            s.WriteQuaternion(bw, m_rotation);
            bw.WriteSingle(m_mass);
            bw.WriteSingle(m_friction);
            bw.WriteSingle(m_maxLinearVelocity);
            bw.WriteSingle(m_allowedPenetrationDepth);
            bw.WriteVector4(m_up);
            bw.WriteSingle(m_maxSlope);
            bw.WriteSingle(m_maxForce);
            bw.WriteSingle(m_unweldingHeightOffsetFactor);
            bw.WriteSingle(m_maxSpeedForSimplexSolver);
            bw.WriteSingle(m_supportDistance);
            bw.WriteSingle(m_hardSupportDistance);
            bw.WriteInt32(m_vdbColor);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

