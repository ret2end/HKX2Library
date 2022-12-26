using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpCharacterProxyCinfo Signatire: 0x586d97b2 size: 144 flags: FLAGS_NONE

    // m_position m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_velocity m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_dynamicFriction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_staticFriction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 52 flags:  enum: 
    // m_keepContactTolerance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 56 flags:  enum: 
    // m_up m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_extraUpStaticFriction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_extraDownStaticFriction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags:  enum: 
    // m_shapePhantom m_class: hkpShapePhantom Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 88 flags:  enum: 
    // m_keepDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_contactAngleSensitivity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags:  enum: 
    // m_userPlanes m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 104 flags:  enum: 
    // m_maxCharacterSpeedForSolver m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 108 flags:  enum: 
    // m_characterStrength m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_characterMass m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 116 flags:  enum: 
    // m_maxSlope m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 120 flags:  enum: 
    // m_penetrationRecoverySpeed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 124 flags:  enum: 
    // m_maxCastIterations m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 128 flags:  enum: 
    // m_refreshManifoldInCheckSupport m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 132 flags:  enum: 
    
    public class hkpCharacterProxyCinfo : hkpCharacterControllerCinfo
    {

        public Vector4 m_position;
        public Vector4 m_velocity;
        public float m_dynamicFriction;
        public float m_staticFriction;
        public float m_keepContactTolerance;
        public Vector4 m_up;
        public float m_extraUpStaticFriction;
        public float m_extraDownStaticFriction;
        public hkpShapePhantom /*pointer struct*/ m_shapePhantom;
        public float m_keepDistance;
        public float m_contactAngleSensitivity;
        public uint m_userPlanes;
        public float m_maxCharacterSpeedForSolver;
        public float m_characterStrength;
        public float m_characterMass;
        public float m_maxSlope;
        public float m_penetrationRecoverySpeed;
        public int m_maxCastIterations;
        public bool m_refreshManifoldInCheckSupport;

        public override uint Signature => 0x586d97b2;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_position = br.ReadVector4();
            m_velocity = br.ReadVector4();
            m_dynamicFriction = br.ReadSingle();
            m_staticFriction = br.ReadSingle();
            m_keepContactTolerance = br.ReadSingle();
            br.Position += 4;
            m_up = br.ReadVector4();
            m_extraUpStaticFriction = br.ReadSingle();
            m_extraDownStaticFriction = br.ReadSingle();
            m_shapePhantom = des.ReadClassPointer<hkpShapePhantom>(br);
            m_keepDistance = br.ReadSingle();
            m_contactAngleSensitivity = br.ReadSingle();
            m_userPlanes = br.ReadUInt32();
            m_maxCharacterSpeedForSolver = br.ReadSingle();
            m_characterStrength = br.ReadSingle();
            m_characterMass = br.ReadSingle();
            m_maxSlope = br.ReadSingle();
            m_penetrationRecoverySpeed = br.ReadSingle();
            m_maxCastIterations = br.ReadInt32();
            m_refreshManifoldInCheckSupport = br.ReadBoolean();
            br.Position += 11;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_position);
            bw.WriteVector4(m_velocity);
            bw.WriteSingle(m_dynamicFriction);
            bw.WriteSingle(m_staticFriction);
            bw.WriteSingle(m_keepContactTolerance);
            bw.Position += 4;
            bw.WriteVector4(m_up);
            bw.WriteSingle(m_extraUpStaticFriction);
            bw.WriteSingle(m_extraDownStaticFriction);
            s.WriteClassPointer(bw, m_shapePhantom);
            bw.WriteSingle(m_keepDistance);
            bw.WriteSingle(m_contactAngleSensitivity);
            bw.WriteUInt32(m_userPlanes);
            bw.WriteSingle(m_maxCharacterSpeedForSolver);
            bw.WriteSingle(m_characterStrength);
            bw.WriteSingle(m_characterMass);
            bw.WriteSingle(m_maxSlope);
            bw.WriteSingle(m_penetrationRecoverySpeed);
            bw.WriteInt32(m_maxCastIterations);
            bw.WriteBoolean(m_refreshManifoldInCheckSupport);
            bw.Position += 11;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

